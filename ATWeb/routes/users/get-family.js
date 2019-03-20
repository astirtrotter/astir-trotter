'use strict';
const models = require('../../models');
const Messages = require('../../config/messages');

module.exports = function (req, res, next) {
    models.Family.scope({ method: ['byId', req.user.familyId] }).findOne().then(family => {
        if (family) {
            family.getUsers().then(users => {
                res.send({
                    success: true,
                    users: users
                });
            });
        } else {
            // family info doesn't exist (internal error)
            var err = new Error(Messages.Error.NoFamily);
            err.status = 500;
            next(err);
        }
    });
};