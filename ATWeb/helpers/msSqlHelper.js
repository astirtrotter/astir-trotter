'use strict';
var Tedious = require("tedious");
var Promise = require("bluebird");

var config = {
    server: process.env.MSSQL_SERVER,
    options: {
        encrypt: false,
        instanceName: process.env.MSSQL_INSTANCE,
        database: process.env.MSSQL_DATABASE,
    },
    authentication: {
        type: 'default',
        options: {
            userName: process.env.MSSQL_USERNAME,
            password: process.env.MSSQL_PASSWORD
        }
    }
};

var msSqlConnecter = function () {
    var currentConnect = this;
    currentConnect.config = config;
    currentConnect.errorHandler;
    currentConnect.connectedHandler;
    currentConnect.connection;

    currentConnect.onConnected = function (callback) {
        currentConnect.connectedHandler = callback;
        return currentConnect;
    };

    currentConnect.onError = function (callback) {
        currentConnect.errorHandler = callback;
        return currentConnect;
    };

    currentConnect.Request = function (sql) {
        var currentRequest = this;
        currentRequest.sql = sql;
        currentRequest.params = [];
        currentRequest.result = [];

        currentRequest.errorHandler;
        currentRequest.completeHandler;

        currentRequest.addParam = function (key, type, value) {
            currentRequest.params.push({ key: key, type: type, value: value });
            return currentRequest;
        }

        currentRequest.Run = function () {
            var request = new Tedious.Request(currentRequest.sql, function (err, rowCount, rows) {
                if (err) {
                    currentRequest.errorHandler(err);
                }
                else {
                    currentRequest.completeHandler(rowCount, currentRequest.result);
                }
            });

            request.on("row", function (columns) {
                var item = {};
                columns.forEach(function (column) {
                    item[column.metadata.colName] = column.value;
                });
                currentRequest.result.push(item);
            });

            for (var i in currentRequest.params) {
                var item = currentRequest.params[i];
                request.addParameter(item.key, item.type, item.value);
            }

            currentConnect.connection.execSql(request);
            return currentRequest;
        };

        currentRequest.onError = function (callback) {
            currentRequest.errorHandler = callback;
            return currentRequest;
        };

        currentRequest.onComplete = function (callback) {
            currentRequest.completeHandler = callback;

            return currentRequest;
        };
    }

    currentConnect.connect = function () {
        var connection = new Tedious.Connection(currentConnect.config);
        currentConnect.connection = connection;
        return Promise.promisify(connection.on.bind(connection))("connect");
    }
};

module.exports = {
    /**
     * insert record
     * @param {any} table - table name
     * @param {any} params - array of {key, type, value}
     * @param {any} callback - function(count)
     */
    insert: function (table, params, callback) {
        var con = new msSqlConnecter();
        con.connect().then(function () {
            var keys = [];
            params.forEach(function (param) {
                keys.push(param.key);
            });
            var values = " values(@".concat(keys.join(",@")).concat(")");
            var request = new con.Request("insert into ".concat(table).concat(values));
            params.forEach(function (param) {
                request.addParam(param.key, param.type, param.value);
            });
            request.onComplete(function (count) {
                if (callback)
                    callback(count);
            })
            .onError(function (err) {
                console.log(err);
            })
            .Run();
        }).catch(function (ex) {
            console.log(ex);
        });
    },

    /**
     * @param {any} table
     * @param {any} criteria
     * @param {any} callback - function(count, data)
     */
    query: function (table, criteria, callback) {
        var con = new msSqlConnecter();
        con.connect().then(function () {
            var query = "select * from ".concat(table);
            if (criteria) {
                query = query.concat(" where ").concat(criteria);
            }
            new con.Request(query)
                .onComplete(function (count, data) {
                    console.log(data);
                    if (callback)
                        callback(count, data);
                })
                .onError(function (err) {
                    console.log(err);
                }).Run();
        }).catch(function (ex) {
            console.log(ex);
        });
    },

    /**
     * @param {any} table - table name
     * @param {any} params - params to update @see insert
     * @param {any} criteria - criteria string, e.g. id > @id
     * @param {any} callback - function(count)
     */
    update: function (table, params, criteria, callback) {
        var con = new msSqlConnecter();
        con.connect().then(function () {
            var keys = [];
            params.forEach(function (param) {
                keys.push(param.key.concat("=@").concat(param.key));
            });
            var sets = " set ".concat(keys.join(",")).concat(" where ");
            var request = new con.Request("update ".concat(table).concat(sets).concat(criteria));
            params.forEach(function (param) {
                request.addParam(param.key, param.type, param.value);
            });
            request.onComplete(function (count) {
                if (callback)
                    callback(count);
            })
            .onError(function (err) {
                console.log(err);
            })
            .Run();
        }).catch(function (ex) {
            console.log(ex);
        });
    },

    /**
     * @param {any} table - table name
     * @param {any} criteria - criteria to delete
     * @param {any} callback - function(count)
     */
    delete: function (table, criteria, callback) {
        var con = new msSqlConnecter();
        con.connect().then(function () {
            new con.Request("delete from ".concat(table).concat(" where ").concat(criteria))
                .onComplete(function (count) {
                    if (callback)
                        callback(count);
                })
                .onError(function (err) {
                    console.log(err);
                })
                .Run();
        }).catch(function (ex) {
            console.log(ex);
        });
    } 
};