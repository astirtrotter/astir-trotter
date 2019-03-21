'use strict';
const models = require('../../models');
const Messages = require('../../config/messages');
const GenderSeed = require('../../config/seed/_gender');

const findUser = function (users, userId) {
    var ret = null;
    if (userId) {
        users.forEach(user => {
            if (user.id == userId) {
                ret = user;
                return;
            }
        });
    }
    return ret;
};

const findChildren = function (users, fatherId, motherId) {
    var ret = [];
    if (fatherId || motherId) {
        users.forEach(user => {
            if (user.fatherId == fatherId && user.motherId == motherId) {
                ret.push(user);
            }
        });
    }
    return ret;
};

const getNode = function (users, userId, isNeedSpouse, isNeedParents, isNeedSiblings, isNeedChildren) {
    if (userId == null) return null;

    var ret = {};
    // oneself
    ret.user = findUser(users, userId);
    users = users.filter(user => user !== ret.user);

    // spouse
    if (isNeedSpouse) {
        ret.spouse = getNode(users, ret.user.spouseId, false, true, true, false);
    }
    // parents
    if (isNeedParents) {
        ret.father = getNode(users, ret.user.fatherId, false, true, true, false);
        ret.mother = getNode(users, ret.user.motherId, false, true, true, false);
    }
    // siblings
    if (isNeedSiblings) {
        var data = [];
        const siblings = findChildren(users, ret.user.fatherId, ret.user.motherId);
        siblings.forEach(sibling => {
            data.push(getNode(users, sibling.id, true, false, false, true));
        });
        if (data.length > 0) ret.siblings = data;
    }
    // children
    if (isNeedChildren) {
        const fatherId = ret.user.gender === GenderSeed[0].value ? ret.user.id : ret.user.spouseId;
        const motherId = ret.user.gender === GenderSeed[0].value ? ret.user.spouseId : ret.user.id;

        var children = findChildren(users, fatherId, motherId);
        children.forEach(child => {
            data.push(getNode(users, child.id, true, false, false, true));
        });
        if (data.length > 0) ret.children = data;
    }

    return ret;
}

module.exports = function (req, res, next) {
    if (req.user) {
        models.Family.scope({ method: ['byId', req.user.familyId] }).findOne().then(family => {
            if (family) {
                family.getUsers().then(users => {
                    // respond family data with structured format
                    var ret = getNode(users, req.user.id);
                    res.send({
                        success: true,
                        family: ret
                    });
                });
            } else {
                // family info doesn't exist (internal error)
                var err = new Error(Messages.Error.NoFamily);
                err.status = 500;
                next(err);
            }
        });
    } else {
        res.send({
            success: false,
            message: Messages.Warning.NotExistUser
        });
    }
};