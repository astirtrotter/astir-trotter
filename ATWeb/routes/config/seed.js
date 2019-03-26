'use strict';

module.exports = function (req, res, next) {
    res.json({
        success: true,
        genders: require('../../config/seed/_gender'),
        parties: require('../../config/seed/_party'),
        nationalities: require('../../config/seed/_nationality'),
        classOrigins: require('../../config/seed/_origin-class'),
        socialOrigins: require('../../config/seed/_origin-social'),
        nationalOrigins: require('../../config/seed/_origin-national'),
        relationships: require('../../config/seed/_relationship')
    });
};