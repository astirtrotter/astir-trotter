'use strict';
const debug = require('debug');
const express = require('express');
const path = require('path');
const favicon = require('serve-favicon');
const logger = require('morgan');
const cookieParser = require('cookie-parser');
const bodyParser = require('body-parser');
const app = express();

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
require('./controllers')(app);

// API
require('./routes')(app);

// middleware
require('./middleware/exceptions')(app);

// server
app.set('port', process.env.PORT || 3000);
var server = app.listen(app.get('port'), function () {
    debug('Server is running on port ' + server.address().port);
});
