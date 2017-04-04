$.fn.accordeon = function(element){ 

  var myList = $(this);
function hideDD(){
    myList
   .children('dd')
   .slideUp();
}

hideDD();

   $($(this).children('dd')[0])
             .show();

   $(this).children('dt')
          .on('click', function(){

            hideDD();

            $(this).next()
                  .show();
          })          
};

var element = $('#acc');
element.accordeon();