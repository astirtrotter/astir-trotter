'use strict';

module.exports = function (req, res, next) {
    res.send({
        success: true,
        user: req.user
    });
};