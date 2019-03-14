'use strict';

module.exports = function (app) {

    require('../middleware/api_versioning')(app);

    require('../middleware/api_params')(app);
    
    app.get(process.env.API_BASE_URL + process.env.API_VERSION + '/:userId', function (req, res, next) {
        res.send(req.user);
    });
};
