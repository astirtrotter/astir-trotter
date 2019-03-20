'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const UserEducationHistory = sequelize.define('UserEducationHistory',
        {
            periodStart: { type: DataTypes.DATEONLY, allowNull: false },
            periodEnd: { type: DataTypes.DATEONLY },
            schoolName: { type: DataTypes.STRING(128), allowNull: false },
            schoolAddress: { type: DataTypes.STRING(256), allowNull: false },
            degree: { type: DataTypes.STRING(50) },
            details: { type: DataTypes.STRING(512) },
        }, {
            timestamps: true,
            scopes: {
                byUserId: function (userId) {
                    return {
                        where: { userId: { [Op.like]: userId } },
                        order: [['periodStart', 'ASC']]
                    };
                }
            }
        });

    return UserEducationHistory;
};
