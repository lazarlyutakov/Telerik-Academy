/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    var fragment = document.createDocumentFragment();
    if (typeof element === 'string') {
      element = document.getElementById(element);
    }

    if (contents.some(function (x) {
      return (typeof x !== 'string' && typeof x !== 'number');
    })
      || !(element instanceof HTMLElement)
      || !Array.isArray(contents)) {
      throw Error('Invalid input');
    }

    contents.forEach(function (el) {
      var added = document.createElement('div');
      added.innerHTML =el;
      fragment.appendChild(added);
    });

    element.innerHTML = '';
    element.appendChild(fragment);
  };
};