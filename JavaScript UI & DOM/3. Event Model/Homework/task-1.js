//'use strict';
/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
  return function (selector) {
    var element;

    if (typeof selector === 'string') {
      element = document.getElementById(selector);

      if (!element) {
        throw Error('DOM element does not exist!');
      }      
    }
    else if(!(selector instanceof HTMLElement)){
      throw Error('Must be a DOM element!');
    }
    else{
      element = selector;
    }

    var buttons = element.getElementsByClassName('button');

    for(var button in buttons){
      var content = buttons[button];
      content.innerHTML = 'hide';
    }

    element.addEventListener('click', function(e){
      var buttonContent = e.target.nextElementSibling;

      if(e.target.className === 'button'){
        if(buttonContent.className === 'content'){
          
          if(buttonContent.style.display === ''){
            buttonContent.style.display = 'none';
            e.target.innerHTML = 'show';
            return;
          }
          if(buttonContent.style.display === 'none'){
            buttonContent.style.display = '';
            e.target.innerHTML = 'hide';
            return;
          }
        }
      }
    }, false);   
  };
};

module.exports = solve;