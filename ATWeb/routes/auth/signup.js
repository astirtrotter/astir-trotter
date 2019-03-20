'use strict';
const models = require('../../models');
const Messages = require('../../config/messages');
const CredentialsHeper = require('../../helpers/credentialsHelper');

module.exports = function (req, res, next) {
    const userId = req.body.userId;

    models.User.scope({ method: ['byId', userId] }).findOne().then(user => {
        if (user) {
            // duplicated userId
            res.send({
                success: false,
                message: Messages.Warning.DuplicatedUserId
            });
        } else {
            // check gender, country, classOrigin, socialOrigin, nationalOrigin, nationality
            models.Gender.scope({ method: ['byValue', req.body.gender] }).findOne().then(gender => {
                if (req.body.gender && !gender) {
                    res.send({
                        success: false,
                        message: Messages.Warning.InvalidInput + Messages.General.Gender
                    });
                } else {
                    models.Country.scope({ method: ['byValue', req.body.country] }).findOne().then(country => {
                        if (req.body.country && !country) {
                            res.send({
                                success: false,
                                message: Messages.Warning.InvalidInput + Messages.General.Country
                            });
                        } else {
                            models.ClassOrigin.scope({ method: ['byValue', req.body.classOrigin] }).findOne().then(classOrigin => {
                                if (req.body.classOrigin && !classOrigin) {
                                    res.send({
                                        success: false,
                                        message: Messages.Warning.InvalidInput + Messages.General.ClassOrigin
                                    });
                                } else {
                                    models.SocialOrigin.scope({ method: ['byValue', req.body.socialOrigin] }).findOne().then(socialOrigin => {
                                        if (req.body.socialOrigin && !socialOrigin) {
                                            res.send({
                                                success: false,
                                                message: Messages.Warning.InvalidInput + Messages.General.SocialOrigin
                                            });
                                        } else {
                                            models.NationalOrigin.scope({ method: ['byValue', req.body.nationalOrigin] }).findOne().then(nationalOrigin => {
                                                if (req.body.nationalOrigin && !nationalOrigin) {
                                                    res.send({
                                                        success: false,
                                                        message: Messages.Warning.InvalidInput + Messages.General.NationalOrigin
                                                    });
                                                } else {
                                                    models.Nationality.scope({ method: ['byValue', req.body.nationality] }).findOne().then(nationality => {
                                                        if (req.body.nationality && !nationality) {
                                                            res.send({
                                                                success: false,
                                                                message: Messages.Warning.InvalidInput + Messages.General.Nationality
                                                            });
                                                        } else {
                                                            models.User.create({
                                                                id: req.body.userId,
                                                                firstName: req.body.firstName,
                                                                lastName: req.body.lastName,
                                                                nickName: req.body.nickName,
                                                                birthDay: req.body.birthDay,
                                                                birthPlace: req.body.birthPlace,
                                                                address: req.body.address,
                                                                picture: req.body.picture,
                                                                phoneNumber: req.body.phoneNumber,
                                                                email: req.body.email,
                                                                moreContactInfo: req.body.moreContactInfo,
                                                                fatherId: req.body.fatherId,
                                                                motherId: req.body.motherId,
                                                                spouseId: req.body.spouseId
                                                            }).then(user => {
                                                                if (user) {
                                                                    if (gender) gender.addUser(user);
                                                                    if (country) country.addUser(user);
                                                                    if (classOrigin) classOrigin.addUser(user);
                                                                    if (socialOrigin) socialOrigin.addUser(user);
                                                                    if (nationalOrigin) nationalOrigin.addUser(user);
                                                                    if (nationality) nationality.addUser(user);

                                                                    // save credentials
                                                                    const pwdHash = CredentialsHeper.genPwdHash(req.body.password);
                                                                    models.UserSetting.create({ pwdHash: pwdHash }).then(userSetting => {
                                                                        if (userSetting) {
                                                                            user.setUserSetting(userSetting);

                                                                            // respond
                                                                            res.send({
                                                                                success: true,
                                                                                user: user
                                                                            });
                                                                        } else {
                                                                            // cannot save user setting
                                                                            var err = new Error(Messages.Error.SaveData);
                                                                            err.status = 500;
                                                                            next(err);
                                                                        }
                                                                    });
                                                                } else {
                                                                    // cannot save user
                                                                    var err = new Error(Messages.Error.SaveData);
                                                                    err.status = 500;
                                                                    next(err);
                                                                }
                                                            }).catch(err => {
                                                                // invalid input
                                                                res.send({
                                                                    success: false,
                                                                    message: Messages.Warning.InvalidInput
                                                                });

                                                            });
                                                        }
                                                    });
                                                }
                                            });
                                        }
                                    });
                                }
                            });
                        }
                    });
                }
            });
        }
    });
};