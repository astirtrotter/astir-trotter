'use strict';
const Messages = require('../../config/messages');

module.exports = function (req, res, next) {
    if (req.user) {
        res.send({
            success: true,
            user: req.user
        });
    } else {
        res.send({
            success: false,
            message: Messages.Warning.NotExistUser
        });
    }
};