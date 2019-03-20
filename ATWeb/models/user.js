'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const User = sequelize.define('User',
        {
            id: { type: DataTypes.STRING(32), allowNull: false, primaryKey: true, validate: { is: /^[a-zA-Z_0-9]+$/ } },
            firstName: { type: DataTypes.STRING(20), allowNull: false },
            lastName: { type: DataTypes.STRING(20), allowNull: false },
            nickName: { type: DataTypes.STRING(50) },
            birthDay: { type: DataTypes.DATEONLY },
            birthPlace: { type: DataTypes.STRING },
            address: { type: DataTypes.STRING },
            picture: { type: DataTypes.STRING, validate: { isUrl: true } },
            phoneNumber: { type: DataTypes.STRING },
            email: { type: DataTypes.STRING, validate: { isEmail: true } },
            moreContactInfos: { type: DataTypes.STRING },
            fatherId: { type: DataTypes.STRING(32) },
            motherId: { type: DataTypes.STRING(32) },
            spouseId: { type: DataTypes.STRING(32) }
        }, {
            timestamps: true,
            paranoid: true,
            scopes: {
                byId: function (id) { return { where: { id: { [Op.like]: id } }, limit: 1 }; },
                live: { where: { deletedAt: null } },
                deleted: { where: { deletedAt: { [Op.ne]: null } } }
            }
        });

    User.associate = function (models) {
        User.hasMany(models.Token);
        User.hasMany(models.UserEducationHistory);
        User.hasMany(models.UserWorkHistory);
        User.hasOne(models.UserSetting);
    };

    return User;
};
