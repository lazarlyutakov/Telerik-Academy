
$(function () {
    var $btn = $('.btn');
    var $tbName = $('.tb-name');
    var $list = $('.list');

    $btn.on('click', function () {
        var text = $tbName.val();
        $tbName.val('');

        var $li = $('<li/>')
            .addClass('list-item')
            .html(text);


        var btnDelete = $('<a/>')
            .addClass('btn')
            .addClass('btn-delete')
            .html('X')
            .appendTo($li);

        $list.append($li);
    });

    $('.tb-search').on('input', function(){
        var $items = $('.list .list-item'),
            pattern = $(this).val();

         $items.each(function(index, node){
             var $node = $(node);
             if($node.text().indexOf(pattern) < 0){
                 $node.addClass('hidden');
             }
             else{
                 $node.removeClass('hidden');
             }
         })   

    })





    $('.list').on('click', '.btn-delete', function(){
        $(this).parents('.list-item')
               .remove();
    })

});