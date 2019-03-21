'use strict';

const PartySeed = require('./_party');
const NationalitySeed = require('./_nationality');
const ClassOriginSeed = require('./_origin-class');
const SocialOriginSeed = require('./_origin-social');
const NationalOriginSeed = require('./_origin-national');

module.exports = function (models, force) {
    if (!force) return;

    models.Party.bulkCreate(PartySeed);
    models.Nationality.bulkCreate(NationalitySeed);
    models.ClassOrigin.bulkCreate(ClassOriginSeed);
    models.SocialOrigin.bulkCreate(SocialOriginSeed);
    models.NationalOrigin.bulkCreate(NationalOriginSeed);
};