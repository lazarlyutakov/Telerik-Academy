import * as homeController from 'homeController';
import * as userController from 'userController';
import * as myCookieController from 'myCookieController';
//import * as userController from 'userController';

var root = null;
var useHash = true;
var hash = '#';

let router = new Navigo(root, useHash, hash);

//IMPLEMENT LATER
//probva s razmenqne na mestata na logi i register!
router.on({
    '': () => location.hash = '#/home',
    '/': () => location.hash = '#/home',
    '/home': homeController.get,
    //'/home/:category': homeController.get,
    //'/my-cookie': myCookieController.get,
    '/auth': userController.get,
    '/login': userController.login,
    '/register': userController.register,
    '/logout': userController.logout
})
    .resolve();




