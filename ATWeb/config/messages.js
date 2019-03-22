'use strict';

module.exports = {
    General: {
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
        InvalidToken: 'Invalid Token',
        Version: 'The version of the client you are using is incorrect. You should update your client app first.',
        NoSetting: 'User settings had not been stored correctly. Please contact admin.',
        NoFamily: 'User family data had not been stored correctly. Please contact admin.',
        SaveData: 'Cannot save token of new login. Please contact admin.'
    }
};