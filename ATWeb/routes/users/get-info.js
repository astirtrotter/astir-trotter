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
                    res.json({
                        success: true,
                        user: user
                    });
                });
            });
        });
    } else {
        res.json({
            success: false,
            message: Messages.Warning.NotExistUser
        });
    }
};