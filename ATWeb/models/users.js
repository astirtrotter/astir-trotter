'use strict';

module.exports = (sequelize, DataTypes) => {
    const User = sequelize.define('Users', {
        UserID: { type: DataTypes.STRING(32), allowNull: false, primaryKey: true, validate: { is: /^[a-z_]+$/ } },
        FirstName: { type: DataTypes.STRING(20), allowNull: false },
        LastName: { type: DataTypes.STRING(20), allowNull: false },
        NickName: { type: DataTypes.STRING(50) },
        Gender: { type: DataTypes.BOOLEAN, allowNull: false },
        BirthDay: { type: DataTypes.DATEONLY },
        BirthPlayce: { type: DataTypes.STRING },
        Address: { type: DataTypes.STRING },
        ClassOrigin: { type: DataTypes.STRING(20) },
        SocialOrigin: { type: DataTypes.STRING(20) },
        NationalOrigin: { type: DataTypes.STRING(20) },
        Nationality: { type: DataTypes.STRING(20) },
        Picture: { type: DataTypes.STRING, validate: { isUrl: true } },
        PhoneNumber: { type: DataTypes.STRING },
        Emails: { type: DataTypes.STRING, validate: { isEmail: true } },
        MoreContactInfos: { type: DataTypes.STRING },
        FatherID: { type: DataTypes.STRING(32) },
        MotherID: { type: DataTypes.STRING(32) },
        SpouseID: { type: DataTypes.STRING(32) },
        Verified: { type: DataTypes.BOOLEAN, allowNull: false },
        timestamps: true,
        paranoid: true
    });

    User.associate = function (models) {

    }

    return User;
};
