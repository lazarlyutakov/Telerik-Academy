define(function() {
  'use strict';
  var Container;
  Container = (function() {
   function Container() {
     this._sections = [];
   
   }

   Container.prototype = {
     add : function(section){
       this._sections.push(section);
       return this;

     },
     getData : function(){
       var section, dataSection, len;

       dataSection = [];

       for(let i = 0, len = this._sections.length; i < len  ; i += 1) {
         sections = this._sections[i];
         dataSection.push(section.getData());
       }

       return dataSection;
       
     }


   }
   return Container;
  }());
  return Container;
});