'use strict';

const models = require('../models');
const Messages = require('../config/messages');

module.exports = function (app) {

    // userId
    app.param('userId', function (req, res, next, userId) {
        models.User.scope({ method: ['byId', userId] }).findOne().then(user => {
            if (user) {
                req.user = user;
                next();
            } else {
                res.json({
                    success: false,
                    message: Messages.Warning.NotExistUser
                });
            }
        });
    });

    // anotherUserId
    app.param('anotherUserId', function (req, res, next, anotherUserId) {
        models.User.scope({ method: ['byId', anotherUserId] }).findOne().then(user => {
            if (user) {
                req.anotherUser = user;
                next();
            } else {
                res.json({
                    success: false,
                    message: Messages.Warning.NotExistUser
                });
            }
        });
    });

}