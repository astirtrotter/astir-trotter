'use strict';

const models = require('../models');

module.exports = function (app) {

    app.param('userId', function (req, res, next, userId) {
        models.Users.findOne({ where: { UserID: userId } }).then(user => {
            req.user = user;
        });
        next();
    });

}