'use strict';
const Messages = require('../../config/messages');

module.exports = function (req, res, next) {
    const caller = req.caller;
    const user = req.user;
    if (user.id === caller.id) {
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
        // send without detailed user info (history, events, etc)
        res.json({
            success: true,
            user: user
        });
    }
};