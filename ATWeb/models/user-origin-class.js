'use strict';

module.exports = (sequelize, DataTypes) => {
    const ClassOrigin = sequelize.define('ClassOrigin',
        {
            value: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; }
            }
        });

    ClassOrigin.associate = function (models) {
        ClassOrigin.hasMany(models.User);
    };

    return ClassOrigin;
};
