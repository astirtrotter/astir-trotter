'use strict';
const Models = require('../../models');
const Messages = require('../../config/messages');
const CredentialsHeper = require('../../helpers/credentialsHelper');

module.exports = function (req, res, next) {
    const userId = req.body.userId;

    Models.User.scope({ method: ['byId', userId] }).findOne().then(user => {
        if (user) {
            // duplicated userId
            res.send({
                success: false,
                message: Messages.Warning.DuplicatedUserId
            });
        } else {
            Models.User.create({
                id: req.body.userId,
                firstName: req.body.firstName,
                lastName: req.body.lastName,
                nickName: req.body.nickName,
                gender: req.body.gender,
                birthDay: req.body.birthDay,
                birthPlace: req.body.birthPlace,
                address: req.body.address,
                classOrigin: req.body.classOrigin,
                socialOrigin: req.body.socialOrigin,
                nationalOrigin: req.body.nationalOrigin,
                nationality: req.body.nationality,
                picture: req.body.picture,
                phoneNumber: req.body.phoneNumber,
                email: req.body.email,
                moreContactInfo: req.body.moreContactInfo,
                fatherId: req.body.fatherId,
                motherId: req.body.motherId,
                spouseId: req.body.spouseId
            }).then(user => {
                if (user) {
                    // save credentials
                    const pwdHash = CredentialsHeper.genPwdHash(req.body.password);
                    Models.UserSetting.create({ pwdHash: pwdHash }).then(userSetting => {
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
};