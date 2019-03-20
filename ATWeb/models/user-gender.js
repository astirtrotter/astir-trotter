'use strict';

module.exports = (sequelize, DataTypes) => {
    const Gender = sequelize.define('Gender',
        {
            value: { type: DataTypes.STRING(10), allowNull: false, primaryKey: true }
        }, {
            timestamps: false,
            scopes: {
                byValue: function (value) { return { where: { value: { [Op.like]: value } }, limit: 1 }; }
            }
        });

    Gender.associate = function (models) {
        Gender.hasMany(models.User);
    };

    return Gender;
};
