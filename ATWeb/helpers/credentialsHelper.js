'use strict';
const Sha256 = require('sha256');
const uuid = require('uuid');
const jwt = require('jsonwebtoken');

module.exports = {
    genToken: function (userId) {
        return jwt.sign({ userId: userId, extra: process.hrtime() }, process.env.TOKEN_SIGN_SECURITY, { expiresIn: process.env.TOKEN_EXPIRES_IN });
    },
    verifyToken: function (token, callback) {
        jwt.verify(token, process.env.TOKEN_SIGN_SECURITY, function (err, decoded) {
            callback(err, decoded);
        });
    },
    genPwdHash: function (pwd) {
        return Sha256.x2(pwd);
    },
    genUUID: function () {
        return uuid.v1();
    }
};