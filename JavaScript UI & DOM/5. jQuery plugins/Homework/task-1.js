function solve() {
  return function (selector) {

    var $selector = $(selector);

    var $wrapperDiv = $('<div/>')
      .addClass('dropdown-list');
    var $body = $('body');
    var $selectTag = $('select');


    $selector.appendTo($wrapperDiv)
      .hide();

    $wrapperDiv.appendTo($body);
    $selectTag.appendTo($wrapperDiv);

    var $current = $('<div/>')
      .appendTo($wrapperDiv)
      .addClass('current')
      .attr('data-value', '')
      .text('Option 1');

    var $divContainer = $('<div/>');
    $divContainer.appendTo($wrapperDiv)
      .addClass('options-container')
      .css('position', 'absolute')
      .css('display', 'none');

    for (var i = 0; i < 5; i += 1) {
      $('<div/>').appendTo($divContainer)
        .addClass('dropdown-item')
        .attr('data-value', `value-${i + 1}`)
        .attr('data-index', i)
        .text('Option' + (i+1));
    }

    $current.on('click', function(){
      $divContainer.css('display', '');
      var $dropDownItems = $('.dropdown-item');
      Array.from($dropDownItems).forEach(item => {
        $item = $(item);
        $item.on('click', function(){
          $current.text(item.innerHTML);
          $divContainer.css('display', 'none');
        });
      });
      
   
    });
  };
}

module.exports = solve;
