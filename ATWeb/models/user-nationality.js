'use strict';

module.exports = (sequelize, DataTypes) => {
    const Nationality = sequelize.define('Nationality',
        {
            value: { type: DataTypes.STRING(50), allowNull: false, primaryKey: true }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; }
            }
        });

    Nationality.associate = function (models) {
        Nationality.hasMany(models.User);
    };

    return Nationality;
};
