'use strict';

module.exports = {
    General: {
        Gender: 'gender',
        Country: 'country',
        Nationality: 'nationality',
        ClassOrigin: 'class origin',
        SocialOrigin: 'social origin',
        NationalOrigin: 'national origin',
        Party: 'party'
    },
    Warning: {
        NotExistUser: 'No user exists with that userId.',
        WrongPassword: 'The password is incorrect.',
        DuplicatedUserId: 'Duplicated userId. Please input another one.',
        InvalidInput: 'Invalid input.'
    },
    Error: {
        NotFound: 'Not Found',
        Version: 'The version of the client you are using is incorrect. Please update and try again.',
        NoSetting: 'User info had not been stored correctly. Please contact admin.',
        GenToken: 'Cannot generate a token. Please contact admin.',
        SaveData: 'Cannot save token of new login. Please contact admin.'
    }
};