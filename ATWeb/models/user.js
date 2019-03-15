'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const User = sequelize.define('User',
        {
            id: { type: DataTypes.STRING(32), allowNull: false, primaryKey: true, validate: { is: /^[a-z_0-9]+$/ } },
            firstName: { type: DataTypes.STRING(20), allowNull: false },
            lastName: { type: DataTypes.STRING(20), allowNull: false },
            nickName: { type: DataTypes.STRING(50) },
            gender: { type: DataTypes.BOOLEAN, allowNull: false },
            birthDay: { type: DataTypes.DATEONLY },
            birthPlayce: { type: DataTypes.STRING },
            address: { type: DataTypes.STRING },
            classOrigin: { type: DataTypes.STRING(20) },
            socialOrigin: { type: DataTypes.STRING(20) },
            nationalOrigin: { type: DataTypes.STRING(20) },
            nationality: { type: DataTypes.STRING(20) },
            picture: { type: DataTypes.STRING, validate: { isUrl: true } },
            phoneNumber: { type: DataTypes.STRING },
            email: { type: DataTypes.STRING, validate: { isEmail: true } },
            moreContactInfos: { type: DataTypes.STRING },
            fatherId: { type: DataTypes.STRING(32) },
            motherId: { type: DataTypes.STRING(32) },
            spouseId: { type: DataTypes.STRING(32) },
            verified: { type: DataTypes.BOOLEAN, allowNull: false, defaultValue: 0 }
        }, {
            timestamps: true,
            paranoid: true,
            scopes: {
                byId: function (id) { return { where: { id: { [Op.like]: id } }, limit: 1 }; },
                live: { where: { deletedAt: null } },
                deleted: { where: { deletedAt: { [Op.ne]: null } } },
                verified: { where: { verified: true } }
            }
        });

    User.associate = function (models) {
        User.hasMany(models.Token);
        User.hasMany(models.UserEducationHistory);
        User.hasMany(models.UserWorkHistory);
    }

    return User;
};
