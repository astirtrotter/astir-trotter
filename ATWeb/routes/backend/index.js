'use strict';

module.exports = function (app) {
    /* middleware */

    // check version
    app.use(function (req, res, next) {
        if (!req.url.startsWith(process.env.API_BASE_URL) ||
            req.url.startsWith(process.env.API_BASE_URL + process.env.VERSION + '/')) {
            return next();
        } else {
            res.status(301);
            return res.send({
                success: false,
                error: {
                    message: 'The version of the client you are using is old. Please update and try again.'
                }
            });
        }
    });

    app.param('userId', function (req, res, next, userId) {

    });
    
    app.get(process.env.API_BASE_URL + process.env.VERSION +
        '/', function (req, res, next) {
        
    });
};
