'use strict';

const models = require('../models');
const Messages = require('../config/messages');
const CredentialsHelper = require('../helpers/credentialsHelper');

const invalidToken = function (next) {
    var err = new Error(Messages.Error.InvalidToken);
    err.status = 401;
    next(err);
}

module.exports = function (app) {

    app.use(function (req, res, next) {
        const authorization = req.headers.authorization;
        if (authorization) {
            if (authorization.startsWith(process.env.TOKEN_PREFIX + ' ')) {
                const callerToken = authorization.slice(process.env.TOKEN_PREFIX.length + 1, authorization.length);
                CredentialsHelper.verifyToken(callerToken, function (err, decoded) {
                    if (decoded) {
                        models.Token.scope({ method: ['byToken', callerToken] }).findOne().then(token => {
                            if (token) {
                                if (token.userId === decoded.userId) {
                                    token.getUser().then(user => {
                                        if (user) {
                                            req.caller = user;
                                            next();
                                        } else {
                                            invalidToken(next);
                                        }
                                    });
                                } else {
                                    invalidToken(next);
                                }
                            } else {
                                invalidToken(next);
                            }
                        });
                    } else {
                        console.log(err);
                        invalidToken(next);
                    }
                });
            } else {
                invalidToken(next);
            }
        } else {
            next();
        }
    });

}