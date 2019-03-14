'use strict';
var Messages = require('../config/messages');

module.exports = function (app) {

    app.all(process.env.API_BASE_URL + '*', function (req, res, next) {
        if (req.url.startsWith(process.env.API_BASE_URL + process.env.API_VERSION + '/')) {
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

};