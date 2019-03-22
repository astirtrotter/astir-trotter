'use strict';
const requestIp = require('request-ip');
const geoIp = require('geoip-lite');
const models = require('../models');

module.exports = function (app) {

    // log request
    app.use(function (req, res, next) {
        const ip = requestIp.getClientIp(req);
        const geo = geoIp.lookup(ip);
        var loc;
        if (geo) {
            loc = geo.city + ", " + geo.country;
        } else {
            loc = 'Local';
        }

        models.Log.create({
            method: req.method,
            reqUrl: req.url,
            reqHeaders: JSON.stringify(req.headers),
            reqBody: JSON.stringify(req.body),
            callerIp: ip,
            callerLocation: loc
        }).then(function (data) {
            console.log(data.get({ plain: true }));
        }).catch(function (error) {
            console.log(error.message);
        });

        next();
    });

}