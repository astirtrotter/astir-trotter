'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const Relationship = sequelize.define('Relationship',
        {
            relation: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true },
            src: { type: DataTypes.STRING(50), allowNull: false },
            dst: { type: DataTypes.STRING(50), allowNull: false }
        }, {
            timestamps: false,
            scopes: {
                byRelation: function (relation) { return { where: { relation: { [Op.like]: relation } }, limit: 1 }; }
            }
        });

    return Relationship;
};
