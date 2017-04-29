import * as data from 'data';
import { load as loadSignUpTemplate } from 'templates';

export function navigate(){
 const $body = $('body');
    $body.css('background-color', '#CCCCCC');

  const $container = $('#app-container');  

  let $logOrSignInMsg = $('#regOrSignIn');
    $logOrSignInMsg.addClass('hidden');

    loadSignUpTemplate('home')
        .then(template => {
            $container.html(template());
        });
}


