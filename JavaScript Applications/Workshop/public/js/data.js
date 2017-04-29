import * as requester from 'ajaxRequester';

export function getUsers() {
  // Add authentication
  return requester.get('api/users');
}

export function login(username, passHash) {
  const body = {
    username,
    passHash
  };

  return requester.put('api/users/auth', body);
}

export function register(username, passHash) {
  const body = {
    username,
    passHash
  };

  return requester.post('api/users', body);
}