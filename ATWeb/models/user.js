'use strict';
var db = require('../helpers/msSqlHelper');
var TYPES = require("tedious").TYPES;

var user = {
    getUserById: function (userId) {
        var ret;
        db.query("Users", "UserId='" + userId + "'", function (count, data) {
            ret = data;
        });
        return ret;
    }
};

module.exports = user;