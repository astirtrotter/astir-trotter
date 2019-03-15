'use strict';

module.exports = (sequelize, DataTypes) => {
    const Token = sequelize.define('Token',
        {
            token: { type: DataTypes.STRING(512), allowNull: false, primaryKey: true }
        }, {
            timestamps: true,
            scopes: {
                byToken: function (token) { return { where: { token: { [Op.like]: token } }, limit: 1 }; }
            }
        });

    return Token;
};
