'use strict';

const fs = require('fs');
const path = require('path');
const Sequelize = require('sequelize');
const basename = path.basename(__filename);
const models = {};
const sequelize = new Sequelize(
    process.env.MSSQL_DATABASE,
    process.env.MSSQL_USERNAME,
    process.env.MSSQL_PASSWORD,
    {
        dialect: 'mssql',
        host: process.env.MSSQL_SERVER,
        port: 1433,
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
        models[model.name] = model;
    });

Object.keys(models).forEach(modelName => {
    if (models[modelName].associate) {
        models[modelName].associate(models);
    }
});

models.sequelize = sequelize;
models.Sequelize = Sequelize;

module.exports = models;