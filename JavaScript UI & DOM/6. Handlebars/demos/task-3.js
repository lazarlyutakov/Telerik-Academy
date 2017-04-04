function solve() {
  return function () {
    $.fn.listview = function (data) {
      var template,
        templateID,
        itemID;

      var $this = $(this);
      templateID = $this.attr('data-template');
      itemID = $('#' + templateID).html();
      template = handlebars.compile(itemID);

      for (var i = 0; i < data.length; i += 1) {
        $this.append(template(data[i]));
      }
    };
  };
}

module.exports = solve;