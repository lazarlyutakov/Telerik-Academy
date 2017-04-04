function solve() {
    return function (selector, tabs) {
        var element = document.querySelector(selector);

        var tabNavigation = document.createElement('ul');
        tabNavigation.className = 'tabs-nav';

        var tabContent = document.createElement('ul');
        tabContent.className = 'tabs-content';

        for (var i = 0; i < tabs.length; i += 1) {
            var liElement = document.createElement('li');
            var anchorElement = document.createElement('a');
            anchorElement.className = 'tab-link visible';
            anchorElement.setAttribute('data-index', i);
            anchorElement.innerHTML = tabs[i].title;

            var tabContentLi = document.createElement('li');
            tabContentLi.className = 'tab-content';
            tabContentLi.setAttribute('data-index', i);
            var pElement = document.createElement('p');
            pElement.innerHTML = tabs[i].content;
            var editButton = document.createElement('button');
            editButton.className = 'btn-edit';
            editButton.innerHTML = 'Edit';

            tabContentLi.appendChild(pElement);
            tabContentLi.appendChild(editButton);

            tabContent.appendChild(tabContentLi);

            liElement.appendChild(anchorElement);
            tabNavigation.appendChild(liElement);
        }

        element.appendChild(tabNavigation);
        element.appendChild(tabContent);

        var tabLink = Array.from(document.getElementsByClassName('tab-link'));
        var content = Array.from(document.getElementsByClassName('tab-content'));

        tabNavigation.addEventListener('click', function (event) {
            var target = event.target;

            if (target.tagName === 'A') {
                content.forEach(x => {
                    if (+target.getAttribute('data-index') === +x.getAttribute('data-index')) {
                        x.className = 'tab-content visible';
                    } else {
                        x.className = 'tab-content';
                    }
                });
            }
        });

        var textArea = document.createElement('textarea');

        tabContent.addEventListener('click', function (event) {
            var target = event.target;

            if (target.className === 'btn-edit') {

                if (target.innerHTML === 'Edit') {
                    target.innerHTML = 'Save';
                    textArea.className = 'edit-content';
                    textArea.value = target.previousSibling.innerHTML;
                    target.parentElement.appendChild(textArea);
                }
                else if (target.innerHTML === 'Save') {
                    target.previousSibling.innerHTML = textArea.value;
                    target.parentElement.removeChild(textArea);
                    target.innerHTML = 'Edit';
                }
            }

        });

    };
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}

