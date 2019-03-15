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

        const token = req.body.token;
        if (token) {
            models.Token.scope({ method: ['byToken', token] }).findOne().then(tokenInfo => {
                models.Log.create({
                    method: req.method,
                    reqUrl: req.url,
                    reqHeaders: JSON.stringify(req.headers),
                    reqBody: JSON.stringify(req.body),
                    callerIp: ip,
                    callerLocation: loc,
                    token: token,
                    userId: tokenInfo.UserId
                }).then(function (data) {
                    res.status(200);
                    res.json(data.get({ plain: true }));
                }).catch(function (error) {
                    res.status(500);
                    res.json({ error: error, stackError: error.stack });
                });
            });
        } else {
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
        }

        next();
    });

}