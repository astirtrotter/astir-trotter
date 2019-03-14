'use strict';
var debug = require('debug');
var express = require('express');
var path = require('path');
var favicon = require('serve-favicon');
var logger = require('morgan');
var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');
var app = express();

require('dotenv').config();

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

// webapp
app.use(favicon(__dirname + '/public/favicon.ico'));
require('./controllers/index')(app);

// API
require('./routes/index')(app);

// middleware
require('./middleware/exceptions')(app);

// server
app.set('port', process.env.PORT || 3000);
var server = app.listen(app.get('port'), function () {
    debug('Server is running on port ' + server.address().port);
});
