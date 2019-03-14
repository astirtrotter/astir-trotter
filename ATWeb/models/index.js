'use strict';

var fs = require('fs');
var path = require('path');
var Sequelize = require('sequelize');
var basename = path.basename(__filename);
var db = {};
var sequelize = new Sequelize(
    process.env.MSSQL_DATABASE,
    process.env.MSSQL_USERNAME,
    process.env.MSSQL_PASSWORD,
    {
        dialect: 'mssql',
        host: process.env.MSSQL_SERVER,
        dialectOptions: {
            instanceName: process.env.MSSQL_INSTANCE
        }
    });

fs.readdirSync(__dirname)
    .filter(file => {
        return (file.indexOf('.') !== 0) && (file !== basename) && (file.slice(-3) === '.js');
    })
    .forEach(file => {
        var model = sequelize['import'](path.join(__dirname, file));
        db[model.name] = model;
    });

Object.keys(db).forEach(modelName => {
    if (db[modelName].associate) {
        db[modelName].associate(db);
    }
});

db.sequelize = sequelize;
db.Sequelize = Sequelize;

module.exports = db;