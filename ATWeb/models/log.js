'use strict';

module.exports = (sequelize, DataTypes) => {
    const Log = sequelize.define('Log',
        {
            method: { type: DataTypes.STRING(10), allowNull: false },
            reqUrl: { type: DataTypes.STRING(512) },
            reqHeaders: { type: DataTypes.STRING(512) },
            reqBody: { type: DataTypes.STRING(512) },
            callerIp: { type: DataTypes.STRING(32) },
            callerLocation: { type: DataTypes.STRING(32) },
            token: { type: DataTypes.STRING(512) },
            userId: { type: DataTypes.STRING(32) }
        }, {
            timestamps: true,
            updatedAt: false,
        });

    return Log;
};
