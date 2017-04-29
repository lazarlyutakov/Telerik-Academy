import * as requester from 'ajaxRequester';

export function getUsers(){
    return requester.get('api/users');
}

export function getCookies(){
    return requester.get('api/cookies');
}

export function login(username, passHash){
    const body = {
        username,
        passHash
    };

    return requester.put('api/auth', body);
}

export function register(username, passHash){
    const body = {
        username,
        passHash
    };

    return requester.post('api/users', body);
}