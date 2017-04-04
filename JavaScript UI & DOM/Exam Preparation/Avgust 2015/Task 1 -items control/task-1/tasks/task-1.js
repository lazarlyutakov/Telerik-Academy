function solve() {
  return function (selector, isCaseSensitive) {

    var element = document.querySelector(selector);
    element.className += 'items-control';

    if (isCaseSensitive === undefined) {
      isCaseSensitive = false;
    }

    var rootDiv = document.getElementById('root');

    var addControlsDiv = document.createElement('div');
    addControlsDiv.className = 'add-controls';
    var inputField = document.createElement('input');
    var inputLabel = document.createElement('label');
    inputLabel.innerHTML = 'Enter text';
    var addButton = document.createElement('button');
    addButton.className = 'button';
    addButton.innerHTML = 'Add';
    element.appendChild(addControlsDiv);
    addControlsDiv.appendChild(inputLabel);
    addControlsDiv.appendChild(inputField);
    addControlsDiv.appendChild(addButton);

    var searchDiv = document.createElement('div');
    searchDiv.className = 'search-controls';
    var searchInput = document.createElement('input');
    var searchInputLabel = document.createElement('label');
    searchInputLabel.innerHTML = 'Search:';
    element.appendChild(searchDiv);
    searchDiv.appendChild(searchInputLabel);
    searchDiv.appendChild(searchInput);

    var resultControlsDiv = document.createElement('div');
    resultControlsDiv.className = 'result-controls';
    var itemsList = document.createElement('div');
    itemsList.className = 'items-list';
    //itemsListDiv.style.display = 'none';
    element.appendChild(resultControlsDiv);
    resultControlsDiv.appendChild(itemsList);

    addButton.addEventListener('click', function () {
      var newList = document.createElement('div');
      newList.className = 'list-item';
      var itemToAddButton = document.createElement('button');
      itemToAddButton.className = ('button');
      itemToAddButton.innerHTML = 'X';
      var itemToAdd = document.createElement('p');
      itemToAdd.className = 'content';
      itemToAdd.innerHTML = inputField.value;

      newList.appendChild(itemToAdd);
      newList.appendChild(itemToAddButton);
      resultControlsDiv.appendChild(newList);
    });

    resultControlsDiv.addEventListener('click', function (ev) {
      if (ev.target.className === 'button') {
        var elementToRemove = event.target.parentElement;
        resultControlsDiv.removeChild(elementToRemove);
      }
    });

  };
}

module.exports = solve;