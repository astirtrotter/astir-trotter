'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const Country = sequelize.define('Country',
        {
            value: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true },
            code: { type: DataTypes.STRING(2), allowNull: false }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; },
                byCode: function (code) { return { where: { code: { [Op.like]: code } }, limit: 1 }; }
            }
        });

    Country.associate = function (models) {
        Country.hasMany(models.User, { foreignKey: 'country' });
    };

    return Country;
};
