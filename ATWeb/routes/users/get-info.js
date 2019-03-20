'use strict';
const models = require('../../models');

module.exports = function (req, res, next) {
    res.send({
        success: true,
        user: req.user
    });
};