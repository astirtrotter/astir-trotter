'use strict';

module.exports = function (app) {

    process.env.API_URL = process.env.API_BASE_URL + process.env.API_VERSION;

    // middleware
    require('../middleware/api_versioning')(app);
    require('../middleware/api_params')(app);

    // routes
    app.get(process.env.API_URL + '/:userId', function (req, res, next) {
        if (req.user) {
            res.send(req.user);
        } else {
            res.send("This user doesn't exist.");
        }
    });
};
