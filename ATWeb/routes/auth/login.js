'use strict';
const models = require('../../models');
const Messages = require('../../config/messages');
const CredentialsHeper = require('../../helpers/credentials');

module.exports = function (req, res, next) {
    const userId = req.body.userId;
    const pwdHash = CredentialsHeper.genPwdHash(req.body.password);
    models.User.scope('live', { method: ['byId', userId] }).findOne().then(user => {
        if (user) {
            // check password
            models.UserSetting.scope({ method: ['byUserId', user.id] }).findOne().then(userSetting => {
                if (userSetting) {
                    if (userSetting.pwdHash == pwdHash) {
                        // generate token
                        const newToken = CredentialsHeper.genToken(userId);
                        // insert login info into Tokens table
                        models.Token.create({ token: newToken, userId: userId }).then(token => {
                            if (token) {
                                token.setUser(user);

                                // respond
                                res.json({
                                    success: true,
                                    token: newToken,
                                    user: user
                                });
                            } else {
                                // cannot save token
                                var err = new Error(Messages.Error.SaveData);
                                err.status = 500;
                                next(err);
                            }
                        });
                    } else {
                        // incorrect password
                        res.json({
                            success: false,
                            message: Messages.Warning.WrongPassword
                        });
                    }
                } else {
                    // setting info doesn't exist (internal error)
                    var err = new Error(Messages.Error.NoSetting);
                    err.status = 500;
                    next(err);
                }
            });
        } else {
            // no user exists with that userId
            res.json({
                success: false,
                message: Messages.Warning.NotExistUser
            });
        }
    });
};