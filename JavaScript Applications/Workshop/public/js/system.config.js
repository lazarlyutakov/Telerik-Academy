SystemJS.config({
 // tell SystemJS which transpiler to use
 transpiler: 'plugin-babel',
 // tell SystemJS where to look for the dependencies
 map: {
  'plugin-babel': 
  'libs/systemjs-plugin-babel/plugin-babel.js',
  'systemjs-babel-build': 
  'libs/systemjs-plugin-babel/systemjs-babel-browser.js',
  // app start script
  'app': 'js/app.js',
  'calc': 'js/calc.js',
  'ajaxRequester': 'js/ajaxRequester.js',
  'data': 'js/data.js',
  'templates': 'js/templates.js',
  'homeController': 'js/controllers/home.js',
  'userController': 'js/controllers/user.js',
  'myCookieController': 'js/controllers/myCookie.js',

  //templates
  //'signUpTemplate': 'templates/signUpForm.handelbars',
 }
});

System.import('app');