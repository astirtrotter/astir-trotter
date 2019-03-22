'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const Token = sequelize.define('Token',
        {
            token: { type: DataTypes.STRING(512), allowNull: false, primaryKey: true }
        }, {
            timestamps: true,
            scopes: {
                byToken: function (token) { return { where: { token: { [Op.like]: token } }, limit: 1 }; }
            }
        });

    Token.associate = function (models) {
        Token.belongsTo(models.User, { foreignKey: 'userId' });
    }

    return Token;
};
