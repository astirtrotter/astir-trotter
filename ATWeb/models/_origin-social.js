'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const SocialOrigin = sequelize.define('SocialOrigin',
        {
            value: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; }
            }
        });

    SocialOrigin.associate = function (models) {
        SocialOrigin.hasMany(models.User, { foreignKey: 'socialOrigin' });
    };

    return SocialOrigin;
};
