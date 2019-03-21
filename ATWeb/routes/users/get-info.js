'use strict';
const Messages = require('../../config/messages');

module.exports = function (req, res, next) {
    const user = req.user;
    if (user) {
        user.getUserEvents().then(events => {
            user.events = events;
            user.getUserEducationHistories().then(educationHistories => {
                user.educationHistories = educationHistories;
                user.getUserWorkHistories().then(workHistories => {
                    user.workHistories = workHistories;
                    res.send({
                        success: true,
                        user: user
                    });
                });
            });
        });
    } else {
        res.send({
            success: false,
            message: Messages.Warning.NotExistUser
        });
    }
};