'use strict';

/*

GET     /config/seed                            // get constants including gender, party, class/social/national origins, nationalities

POST    /auth/login
POST    /auth/signup

// following APIs required token in Header (authorization)

GET     /users/:userId
GET     /users/:userId/family
*GET    /users/relation/:userId/:anotherUserId  // get relation between 2 users
*POST   /users/relation/:userId                 // request relation-add with someone
*PUT    /users/relation/:userId                 // confirm relation-add with requester
*DEL    /users/relation/:userId                 // delete relation with 
  
 */


module.exports = function (app) {

    process.env.API_URL = process.env.API_BASE_URL + process.env.API_VERSION;

    // middleware
    require('../middleware/api_versioning')(app);
    require('../middleware/api_token')(app);
    require('../middleware/api_params')(app);


    // config
    app.get(process.env.API_URL + '/config/seed', function (req, res, next) { require('./config/seed')(req, res, next); });

    // auth
    app.post(process.env.API_URL + '/auth/login', function (req, res, next) { require('./auth/login')(req, res, next); });
    app.post(process.env.API_URL + '/auth/signup', function (req, res, next) { require('./auth/signup')(req, res, next); });

    // users
    app.get(process.env.API_URL + '/users/:userId', function (req, res, next) { require('./users/info')(req, res, next); });
    app.get(process.env.API_URL + '/users/:userId/family', function (req, res, next) { require('./users/family')(req, res, next); });

};
