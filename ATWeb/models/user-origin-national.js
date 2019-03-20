'use strict';

module.exports = (sequelize, DataTypes) => {
    const NationalOrigin = sequelize.define('NationalOrigin',
        {
            value: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; }
            }
        });

    NationalOrigin.associate = function (models) {
        NationalOrigin.hasMany(models.User);
    };

    return NationalOrigin;
};
