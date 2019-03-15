'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const Token = sequelize.define('Token',
        {
            token: { type: DataTypes.STRING(512), allowNull: false, primaryKey: true }
        }, {
            timestamps: true,
            updatedAt: false,
            paranoid: false,
            scopes: {
                byToken: function (token) { return { where: { token: { [Op.like]: token } }, limit: 1 }; }
            }
        });

    return Token;
};
