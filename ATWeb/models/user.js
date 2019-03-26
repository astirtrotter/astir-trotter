'use strict';
const GenderSeed = require('../config/seed/_gender');

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const User = sequelize.define('User',
        {
            id: { type: DataTypes.STRING(32), allowNull: false, primaryKey: true, validate: { is: /^[a-zA-Z_0-9]+$/ } },
            firstName: { type: DataTypes.STRING(20), allowNull: false, validate: { is: /^[a-zA-Z]+$/ } },
            lastName: { type: DataTypes.STRING(20), allowNull: false, validate: { is: /^[a-zA-Z]+$/ } },
            nickName: { type: DataTypes.STRING(50), validate: { is: /^[a-zA-Z ]+$/ } },
            gender: { type: DataTypes.STRING(10), allowNull: false, validate: { isIn: [GenderSeed.map(it => it.value)] } },
            birthday: { type: DataTypes.DATEONLY, allowNull: false },
            birthPlace: { type: DataTypes.STRING },
            address: { type: DataTypes.STRING },
            picture: { type: DataTypes.STRING, validate: { isUrl: true } },
            phoneNumber: { type: DataTypes.STRING },
            email: { type: DataTypes.STRING, validate: { isEmail: true } },
            diedDay: { type: DataTypes.DATEONLY },
            details: { type: DataTypes.STRING },
            fatherId: { type: DataTypes.STRING(32) },
            motherId: { type: DataTypes.STRING(32) },
            spouseId: { type: DataTypes.STRING(32) }
        }, {
            timestamps: true,
            paranoid: true,
            scopes: {
                byId: function (id) { return { where: { id: { [Op.like]: id } }, limit: 1 }; },
                live: { where: { deletedAt: null } }
            }
        });

    User.associate = function (models) {
        User.hasMany(models.UserEducationHistory, { foreignKey: 'userId' });
        User.hasMany(models.UserWorkHistory, { foreignKey: 'userId' });
        User.hasMany(models.UserEvent, { foreignKey: 'userId' });
        User.hasOne(models.UserSetting, { foreignKey: 'userId' });
    };

    User.Instance.prototype.isMale = function () {
        return gender === GenderSeed[0].value;
    };

    return User;
};
