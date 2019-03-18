'use strict';
const Crypto = require('crypto');
const Sha256 = require('sha256');

module.exports = {
    genToken: function () {
        const buf = Crypto.randomBytes(48);
        if (buf) {
            return buf.toString('hex');
        } else {
            return null;
        }
    },
    genPwdHash: function (pwd) {
        return Sha256.x2(pwd);
    }
};