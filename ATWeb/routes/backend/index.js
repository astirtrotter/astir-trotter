'use strict';
var Messages = require('../../helpers/messages');

module.exports = function (app) {
    /* middleware */

    // check version
    app.all(process.env.API_BASE_URL + '*', function (req, res, next) {
        if (req.url.startsWith(process.env.API_BASE_URL + process.env.VERSION + '/')) {
            return next();
        } else {
            res.status(301);
            return res.send({
                success: false,
                error: {
                    message: Messages.Error.Version
                }
            });
        }
    });

    app.param('userId', function (req, res, next, userId) {
        var User = require('../../models/user');
        req.user = User.getUserById(userId);
        next();
    });
    
    app.get(process.env.API_BASE_URL + process.env.VERSION + '/:userId', function (req, res, next) {
        res.send(req.user);
    });
};
