/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {

    if (typeof selector !== 'string' || !selector) {
      throw Error('Selector must be a valid string');
    }

    var $selectorVariable = $(selector);

    var $unorderedList = $('<ul/>')
      .addClass('items-list');

    $unorderedList.appendTo($selectorVariable);

    if (!count) {
      throw Error('Count parameter is missing');
    }

    if (typeof count !== 'number' || count < 1) {
      throw Error('Count must be a number greater than 1');
    }

    for (var i = count; i > 0; i -= 1) {
      $('<li>' + `List item #${count - i}` + '</li>').appendTo($unorderedList)
        .addClass('list-item');
    }
  };
}

module.exports = solve;