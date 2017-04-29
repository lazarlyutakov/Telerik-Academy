import * as data from 'data';
import { load as loadSignUpTemplate } from 'templates';

const $container = $('#app-container');

const LOCALSTORAGE_AUTH_KEY_NAME = 'authkey';
const AUTH_KEY_HEADER = 'x-auth-key';

export function get(params) {
    //const { category } = params;
    let $logOrSignInMsg = $('#regOrSignIn');
    $logOrSignInMsg.addClass('hidden');

    loadSignUpTemplate('signedUp')
        .then(template => {
            $container.html(template());
        });
}

export function login() {
    const username = $('username').val();
    const password = $('#password').val();
    const passHash = password;

    data.login(username, passHash)
        .then(
        result => {
            localStorage.setItem(LOCALSTORAGE_AUTH_KEY_NAME, result.result.authKey);
            location.href = '#home';
        }
        );
}

export function register() {
    const username = $('username').val();
    const password = $('#password').val();
    const passHash = password;
    data.register(username, passHash)
      .then(
          result => {
              
              login();
          }
      );
}