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
  'homeController': 'js/controllers/homeController.js',
  'signedController': 'js/controllers/signedController.js',
  'templates': 'js/templates.js',
   'signUpForm': 'js/controllers/signUpForm.js',
  'firstTimeSignedUp': 'js/controllers/firstTimeSignedUp.js',
  //'userController': 'js/controllers/userController.js'

  //templates
  //'signUpTemplate': 'templates/signUpForm.handelbars',
 }
});

System.import('app');