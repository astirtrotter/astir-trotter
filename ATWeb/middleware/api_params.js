'use strict';

const models = require('../models');

module.exports = function (app) {

    app.param('userId', function (req, res, next, userId) {
        //models.User.scope({ method: ['byId', userId] }).findAll()
        models.User.findOne({ where: { id: userId } }).then(user => {
            req.user = user;
            next();
        });
    });

}