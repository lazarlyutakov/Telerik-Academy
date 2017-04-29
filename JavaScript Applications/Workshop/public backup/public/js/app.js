import * as homeController from 'homeController';
import * as signedController from 'signedController';
import * as signUpForm from 'signUpForm';
import * as firstTimeSignedUp from 'firstTimeSignedUp';
//import * as userController from 'userController';

var root = null;
var useHash = true;
var hash = '#';

let router = new Navigo(root, useHash, hash);

//IMPLEMENT LATER
//probva s razmenqne na mestata na logi i register!
router.on({
    '/home': homeController.navigate,
    '/signupForm': signUpForm.get,
    '/registered': firstTimeSignedUp.get,
    '/registered': firstTimeSignedUp.register,
    '/registered': firstTimeSignedUp.login
})
    .resolve();




