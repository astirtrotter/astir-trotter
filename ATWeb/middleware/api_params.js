'use strict';

module.exports = function (app) {

    app.param('userId', function (req, res, next, userId) {
        var User = require('../models/user');
        req.user = User.getUserById(userId);
        next();
    });

}