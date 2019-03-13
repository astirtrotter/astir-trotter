'use strict';
var Tedious = require("tedious");
var Promise = require("bluebird");
var TYPES = Tedious.TYPES;

var msSqlConnecter = function () {
    var currentConnect = this;
    currentConnect.config = {
        server: 'localhost\\devnamedinstance',
        options: {
            database: 'AstirTrotterDB'
        },
        authentication: {
            type: 'default'
        }
    };
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
        currentRequest.onComplateHandler;

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
                    currentRequest.onComplateHandler(rowCount, currentRequest.result);
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

        currentRequest.onComplate = function (callback) {
            currentRequest.onComplateHandler = callback;

            return currentRequest;
        };
    }

    currentConnect.connect = function () {
        var connection = new Tedious.Connection(config);
        currentConnect.connection = connection;
        return Promise.promisify(connection.on.bind(connection))("connect");
    }
};

module.exports = {
    /**
     * insert record
     * @param {any} table - table name
     * @param {any} params - array of {field, type, value}
     * @param {any} callback - function(count)
     */
    insert: function insert(table, params, callback) {
        var con = new msSqlConnecter.msSqlConnecter();
        con.connect().then(function () {
            var fields = [];
            params.forEach(param) {
                fields.push(param.field);
            };
            var values = " values(@".concat(fields.join(",@")).concat(")");
            var request = new con.Request("insert into ".concat(table).concat(values));
            params.forEach(param) {
                request.addParam(param.field, param.type, param.value);
            };
            request.onComplate(function (count) {
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
     * 
     * @param {any} table
     * @param {any} callback
     */
    queryAll: function queryAll(table, callback) {
        var con = new msSqlConnecter.msSqlConnecter();
        con.connect().then(function () {
            new con.Request("select * from ".concat(table))
                .onComplate(function (count, data) {
                    if (callback)
                        callback(data);
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
    update: function updateData(table, params, criteria, callback) {
        var con = new msSqlConnecter.msSqlConnecter();
        con.connect().then(function () {
            var fields = [];
            params.forEach(param) {
                fields.push(param.field.concat("=@").concat(param.field));
            };
            var sets = " set ".concat(fields.join(",")).concat(" where ");
            var request = new con.Request("update ".concat(table).concat(sets).concat(criteria));
            params.forEach(param) {
                request.addParam(param.field, param.type, param.value);
            };
            request.onComplate(function (count) {
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
    delete: function deleteData(table, criteria, callback) {
        var con = new msSqlConnecter.msSqlConnecter();
        con.connect().then(function () {
            new con.Request("delete from ".concat(table).concat(" where ").concat(criteria))
                .addParam("id", TYPES.Int, 3)
                .onComplate(function (count) {
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