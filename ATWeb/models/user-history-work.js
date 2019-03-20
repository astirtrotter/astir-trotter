'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const UserWorkHistory = sequelize.define('UserWorkHistory',
        {
            periodStart: { type: DataTypes.DATEONLY, allowNull: false },
            periodEnd: { type: DataTypes.DATEONLY },
            companyName: { type: DataTypes.STRING(128), allowNull: false },
            companyAddress: { type: DataTypes.STRING(256), allowNull: false },
            position: { type: DataTypes.STRING(50), allowNull: false },
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

    return UserWorkHistory;
};
