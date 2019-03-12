'use strict';
var express = require('express');
var router = express.Router();

// check if this is valid request
router.use(function (req, res, next) {
    if (req.body.ver === process.env.VERSION) {
        next();
    } else {
        res.status(301);
        res.send({
            success: false,
            error: {
                message: 'The version of the client is old. Please update and try again.'
            }
        })
    }
});

router.get('/', function (req, res) {
    res.send('respond with a resource');
});

module.exports = router;
