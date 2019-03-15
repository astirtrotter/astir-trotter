'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const UserSetting = sequelize.define('UserSetting',
        {
            pwd: { type: DataTypes.STRING(512), allowNull: false },
            share: { type: DataTypes.STRING(512) }
        }, {
            timestamps: true,
            scopes: {
                byToken: function (token) { return { where: { token: { [Op.like]: token } }, limit: 1 }; }
            }
        });

    return UserSetting;
};
