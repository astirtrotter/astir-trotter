'use strict';

module.exports = (sequelize, DataTypes) => {
    const Op = require('sequelize').Op;
    const UserEvent = sequelize.define('UserEvent',
        {
            at: { type: DataTypes.DATEONLY },
            location: { type: DataTypes.DATEONLY },
            details: { type: DataTypes.STRING(512) },
        }, {
            timestamps: true,
            scopes: {
                byUserId: function (userId) {
                    return {
                        where: { userId: { [Op.like]: userId } },
                        order: [['when', 'ASC']]
                    };
                }
            }
        });

    return UserEvent;
};
