function solve() {
    return function (selector, initialSuggestions) {

        var element = document.querySelector(selector);

        var tbPattern = element.getElementByClassName('tb-pattern')[0];
        var suggestionsItems = element.getElementByClassName('suggestion');
        var suggestionsList = element.getElementByClassName('suggestions-list')[0];
        var btnAdd = element.getElementByClassName('btn-add')[0];
        var pattern = '';

        var suggestionItemTemplate = document.createElement('li');
        var suggestionLinkTemplate = document.createElement('a');

        suggestionItemTemplate.className = 'suggestion';

        suggestionLinkTemplate.className = 'suggestion-link';
        suggestionLinkTemplate.href = '#';
        suggestionItemTemplate.appendChild(suggestionLinkTemplate);
        suggestionItemTemplate.style.display = 'none';

        var usedSuggestions = {};

        initialSuggestions = initialSuggestions || [];

        for(let i = 0; i < initialSuggestions.length ; i += 1) {
            var suggestionString = initialSuggestions[i];

            if(!usedSuggestions[suggestionString.toLowerCase()]){
                suggestionLinkTemplate.innerHTML = suggestionString;
                var newSuggestion = suggestionItemTemplate.cloneNode(true);
                suggestionsList.appendChild(newSuggestion);
                usedSuggestions[suggestionString.toLowerCase()] = true;
            }           
        }

        suggestionsList.addEventListener('click', function(ev){
            var btn = ev.target,
                text;

            if(btn.className.indexOf('suggestion-link') < 0){
                return;
            }

            text = btn.innerHTML;
            tbPattern.value = text;    
            ev.preventDefault();
        });

        suggestionsList.style.display = 'none';

        btnAdd.addEventListener('click', function(){
            var value = tbPattern.value;
            tbPattern.value = '';

            suggestionsList.style.display = 'none';

            if(!usedSuggestions[value.toLowerCase()]){
                suggestionLinkTemplate.innerHTML = value;
                suggestionsList.appendChild(suggestionItemTemplate.cloneNode(true));
                usedSuggestions[value.toLowerCase()] = true;
            }
        });

        tbPattern.addEventListener('input', function(){
            var suggestionItems = element.getElementByClassName('seggestion');

            var len = suggestionItems.length,
               suggestionItem,
               suggestionText,
               i;

               pattern = this.value.toLowerCase();

               if(pattern === ''){
                   suggestionsList.style.display = 'none';
                   return;
               }

               suggestionsList.style.display = '';

               for(let i = 0; i < len ; i += 1) {
                   suggestionItem = suggestionsItems[i];
                   suggestionText = suggestionItem.getElementByClassName('sugegstion-link')[0];

                   if(suggestionText.innerHTML.toLowerCase().indexOf(pattern) >= 0){
                       suggestionItem.style.display = '';

                   } else {
                       suggestionItem.style.display = 'none';
                   }
                   
               }
        });

    };
}

module.exports = solve;