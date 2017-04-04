function solve() {
	var template = [

"\n\t\t<div class = 'tabs-control'>\n\t\t      <ul class = 'list list-titles'>\n\t\t\t    {{#titles}}\n\t\t\t\t   <li class = 'list-item'>\n\t\t\t\t     <label for = '{{link}}' class = 'title'>{{text}}</label>\n\t\t\t\t   </li>\n\t\t\t\t{{/titles}}\n                </ul>\n                <ul class = 'list list-contents'>\n                    {{#contents}}\n                       <li class = 'list-item'>\n                           <input class = 'tab-content-toggle' id = '{{link}}' name = 'tab-toggles' {{#if checked}}checked = 'checked/'/{{/if}} type = 'radio'>\n                           <div class = 'content'>\n                               {{{text}}}\n                           </div>    \n                       </li>    \n                    {{/contents}}\n                </ul>    \n\t\t\t  </ul>\n\t\t   </div>\n\t          \n              \n\n\t\t"          
        ].join('\n');
        return template;
}

if(typeof module !== 'undefined') {
	module.exports = solve;
}
