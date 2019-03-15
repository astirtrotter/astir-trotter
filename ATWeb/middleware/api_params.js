'use strict';

const models = require('../models');

module.exports = function (app) {

    app.param('userId', function (req, res, next, userId) {
        models.User.scope({ method: ['byId', userId] }).findOne().then(user => {
            req.user = user;
            next();
        });
    });

}