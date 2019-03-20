'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const Family = sequelize.define('Family',
        {
            id: { type: DataTypes.UUID, allowNull: false, primaryKey: true }
        }, {
            timestamps: true,
            paranoid: true,
            scopes: {
                byId: function (id) { return { where: { id: { [Op.like]: id } }, limit: 1 }; }
            }
        });

    Family.associate = function (models) {
        Family.hasMany(models.User, { foreignKey: 'familyId' });
    };

    return Family;
};
