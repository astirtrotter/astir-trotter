'use strict';

const models = require('../models');

module.exports = function (app) {

    // userId
    app.param('userId', function (req, res, next, userId) {
        models.User.scope({ method: ['byId', userId] }).findOne().then(user => {
            req.user = user;
            next();
        });
    });

    // anotherUserId
    app.param('anotherUserId', function (req, res, next, anotherUserId) {
        models.User.scope({ method: ['byId', anotherUserId] }).findOne().then(user => {
            req.anotherUser = user;
            next();
        });
    });

}