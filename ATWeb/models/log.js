'use strict';

module.exports = (sequelize, DataTypes) => {
    const Log = sequelize.define('Log',
        {
            method: { type: DataTypes.STRING(10), allowNull: false },
            endpoint: { type: DataTypes.STRING(512) },
            header: { type: DataTypes.STRING(512) },
            params: { type: DataTypes.STRING(1024) },
            response: { type: DataTypes.STRING(512) },
            token: { type: DataTypes.STRING(512) },
            userId: { type: DataTypes.STRING(32) },
            callerIp: { type: DataTypes.STRING(16) },
            callerLocation: { type: DataTypes.STRING(512) },
            callerPlatform: { type: DataTypes.STRING(512) },
        }, {
            timestamps: true,
            updatedAt: false,
        });

    return Log;
};
