import * as data from 'data';
import { load as loadTemplate } from 'templates';

const $appContainer = $('#app-container');

const LOCALSTORAGE_AUTH_KEY_NAME = 'authkey';
const AUTH_KEY_HEADER = 'x-auth-key';

export function get(params) {
  //const { category } = params;
console.log(555);
  loadTemplate('auth')
    .then(template => {
      $appContainer.html(template());
    });
}

export function login() {
  const username = $('#input-username').val();
  const password = $('#input-password').val();
  const passHash = password; // HASH ME

  data.login(username, passHash)
    .then(
        result => {
          localStorage.setItem(LOCALSTORAGE_AUTH_KEY_NAME, result.result.authKey);
          $('#auth-btn').addClass('hidden');
          $('#signout-btn').removeClass('hidden');
          location.href = '#/home';
        });
}

export function register() {
  const username = $('#input-username').val();
  const password = $('#input-password').val();
  const passHash = password; // HASH ME

  data.register(username, passHash)
    .then(
        result => {
          login();
        });
}

export function logout() {
  localStorage.removeItem(LOCALSTORAGE_AUTH_KEY_NAME);
  $('#auth-btn').removeClass('hidden');
  $('#signout-btn').addClass('hidden');
  location.href = '#/home';
}