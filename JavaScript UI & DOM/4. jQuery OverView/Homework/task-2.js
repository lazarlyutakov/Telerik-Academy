/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    if (typeof selector !== 'string') {
      throw Error('Selector must be a string');
    }

    if (!($(selector).length)) {
      throw Error('Selector is not valid');
    }

    var $element = $(selector);
    var $buttons = $element.find('.button');

    $buttons.html('hide');

    $buttons.on('click', function () {
      var $this = $(this);
      var $otherContent = $this.nextAll('.content').first();
      var $otherButton = $otherContent.nextAll('.button').first();

      if ($otherButton.length && $otherContent.length) {
        if ($otherContent.css('display') === 'none') {
          $otherContent.css('display', '');
          $this.html('hide');
        }
        else {
          $otherContent.css('display', 'none');
          $this.html('show');
        }
      }
    });
  };
}

module.exports = solve;