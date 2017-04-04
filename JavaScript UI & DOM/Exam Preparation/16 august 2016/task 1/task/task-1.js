function solve() {
    return function (selector, initialSuggestions) {

        var element = document.querySelector(selector);

        var textBox = document.getElementsByClassName('tb-pattern')[0];
        var suggestionList = document.getElementsByClassName('suggestions-list')[0];
        var addButton = document.getElementsByClassName('btn-add')[0];
        var lis = document.getElementsByTagName('li');

        if (initialSuggestions) {
            for (var i = 0; i < initialSuggestions.length; i += 1) {
                var suggestion = document.createElement('li');
                suggestion.className = 'suggestion';
                var suggestionLink = document.createElement('a');
                suggestionLink.className = 'suggestion-link';
                suggestionLink.href = '#';
                suggestion.appendChild(suggestionLink);
                suggestionLink.innerHTML = initialSuggestions[i];
                suggestionList.style.display = 'none';
                element.appendChild(suggestion);
            }
        }

        addButton.addEventListener('click', function () {
            var suggestion = document.createElement('li');
            suggestion.className = 'suggestion';
            var suggestionLink = document.createElement('a');
            suggestionLink.className = 'suggestion-link';
            suggestionLink.href = '#';
            suggestion.appendChild(suggestionLink);
            suggestionLink.innerHTML = textBox.value;
            suggestionList.appendChild(suggestion);
            suggestion.style.display = 'none';
        });

        textBox.addEventListener('input', function () {
            var input = textBox.value;
            for (var i = 0; i < initialSuggestions.length; i += 1) {
                if (initialSuggestions[i].toLowerCase().includes(input.toLowerCase())) {
                    suggestionList.style.display = 'flex';
                }
            }
        });
    };
}

module.exports = solve;