'use strict';
const Models = require('../../models');
const Messages = require('../../config/messages');
const CredentialsHeper = require('../../helpers/credentialsHelper');

module.exports = function (req, res, next) {
    const userId = req.body.userId;
    const pwdHash = CredentialsHeper.genPwdHash(req.body.password);
    Models.User.scope('live', { method: ['byId', userId] }).findOne().then(user => {
        if (user) {
            // check password
            Models.UserSetting.scope({ method: ['byUserId', user.id] }).findOne().then(userSetting => {
                if (userSetting) {
                    if (userSetting.pwdHash == pwdHash) {
                        // generate token
                        const newToken = CredentialsHeper.genToken();
                        if (newToken) {
                            // insert login info into Tokens table
                            Models.Token.create({ token: newToken, userId: userId }).then(token => {
                                if (token) {
                                    user.addToken(token);

                                    // respond
                                    res.send({
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
                            // cannot generate token (internal error)
                            var err = new Error(Messages.Error.GenToken);
                            err.status = 500;
                            next(err);
                        }
                    } else {
                        // incorrect password
                        res.send({
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
            res.send({
                success: false,
                message: Messages.Warning.NotExistUser
            });
        }
    });
};