'use strict';

const GenderSeed = require('./user-gender');
const CountrySeed = require('./user-country');
const NationalitySeed = require('./user-nationality');
const ClassOriginSeed = require('./user-origin-class');
const SocialOriginSeed = require('./user-origin-social');
const NationalOriginSeed = require('./user-origin-national');

module.exports = function (models, force) {
    if (!force) return;

    models.Gender.bulkCreate(GenderSeed);
    models.Country.bulkCreate(CountrySeed);
    models.Nationality.bulkCreate(NationalitySeed);
    models.ClassOrigin.bulkCreate(ClassOriginSeed);
    models.SocialOrigin.bulkCreate(SocialOriginSeed);
    models.NationalOrigin.bulkCreate(NationalOriginSeed);
};