'use strict';

const models = require('../models');
const Messages = require('../config/messages');
const CredentialsHelper = require('../helpers/credentials');

const invalidToken = function (next) {
    var err = new Error(Messages.Error.InvalidToken);
    err.status = 401;
    next(err);
};

const notTokenRequiredUrls = [
    process.env.API_URL + '/config/seed',
    process.env.API_URL + '/auth/login',
    process.env.API_URL + '/auth/signup'
];

const withoutToken = function (next) {
    var err = new Error(Messages.Error.TokenRequired);
    err.status = 400;
    next(err);
};

module.exports = function (app) {

    app.use(function (req, res, next) {
        if (notTokenRequiredUrls.indexOf(req.url) > -1) {
            next();
        } else {
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
                withoutToken(next);
            }
        }
    });

}