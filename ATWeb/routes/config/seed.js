'use strict';

module.exports = function (req, res, next) {
    res.send({
        success: true,
        seed: {
            gender: require('../../config/seed/_gender'),
            party: require('../../config/seed/_party'),
            nationality: require('../../config/seed/_nationality'),
            classOrigin: require('../../config/seed/_origin-class'),
            socialOrigin: require('../../config/seed/_origin-social'),
            nationalOrigin: require('../../config/seed/_origin-national')
        }
    });
};