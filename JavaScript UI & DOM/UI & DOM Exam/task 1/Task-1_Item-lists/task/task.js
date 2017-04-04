function solve() {

	return function (selector, defaultLeft, defaultRight) {
		var root = document.querySelector(selector);

		var columnContainer = document.createElement('div');
		columnContainer.className = 'column-container';
		root.appendChild(columnContainer);

		var column,
			selectColumn,
			radioButton,
			orderedList,
			label;

		for (var i = 0; i < 2; i += 1) {
			column = document.createElement('div');
			column.className = 'column';

			selectColumn = document.createElement('div');
			selectColumn.className = 'select';

			radioButton = document.createElement('input');
			radioButton.type = 'radio';
			radioButton.name = 'column-select';

			label = document.createElement('label');
			label.innerHTML = 'Add here';

			orderedList = document.createElement('ol');

			selectColumn.appendChild(radioButton);
			selectColumn.appendChild(label);
			column.appendChild(selectColumn);
			column.appendChild(orderedList);
			columnContainer.appendChild(column);
		}

		var inputField = document.createElement('input');
		//inputField.style.resize = '40px';
		var addButton = document.createElement('button');
		addButton.innerHTML = 'Add';
		root.appendChild(inputField);
		root.appendChild(addButton);

		var olList = root.getElementsByTagName('ol');

		// if (defaultLeft.length) {
		// 	for (var i = 0; i < defaultLeft.length; i += 1) {
		// 		var newLi = document.createElement('li');
		// 		var image = document.createElement('img');
		// 		image.src = 'imgs/Remove-icon.png';
		// 		image.className = 'delete';
		// 		newLi.className = 'entry';
		// 		newLi.innerHTML = defaultLeft[i];

		// 		newLi.appendChild(image);
		// 		olList[0].appendChild(newLi);
		// 	}
		// }

		// if (defaultRight.length) {
		// 	for (var i = 0; i < defaultRight.length; i += 1) {
		// 		var newLi = document.createElement('li');
		// 		var image = document.createElement('img');
		// 		image.src = 'imgs/Remove-icon.png';
		// 		image.className = 'delete';
		// 		newLi.className = 'entry';
		// 		newLi.innerHTML = defaultRight[i];

		// 		newLi.appendChild(image);
		// 		olList[1].appendChild(newLi);
		// 	}
		// }

		var newSelectColumn = root.getElementsByClassName('select');
		newSelectColumn[0].firstChild.setAttribute('id', 'select-left-column');
		newSelectColumn[0].firstChild.setAttribute('checked', 'checked');
		newSelectColumn[1].firstChild.setAttribute('id', 'select-right-column');

		var isLeftChecked = document.getElementById('select-left-column').checked;
		var isRightCkecked = document.getElementById('select-right-column').checked;
		var img = document.createElement('img');

		newSelectColumn[1].firstChild.addEventListener('click', function(){
			isLeftChecked = false;
		});

		console.log(isLeftChecked);


		if (isLeftChecked) {
			addButton.addEventListener('click', function () {
				var li = document.createElement('li');
				img.src = 'imgs/Remove-icon.png';
				img.className = 'delete';
				li.className = 'entry';
				li.innerHTML = inputField.value.trim();
				if (inputField.value !== '') {
					li.appendChild(img);
					olList[0].appendChild(li);
					inputField.value = '';
				}
				else {
					return;
				}
			});
		}
		else{
			addButton.addEventListener('click', function () {
				var li = document.createElement('li');
				img.src = 'imgs/Remove-icon.png';
				img.className = 'delete';
				li.className = 'entry';
				li.innerHTML = inputField.value.trim();
				if (inputField.value !== '') {
					li.appendChild(img);
					olList[1].appendChild(li);
					inputField.value = '';
				}
				else {
					return;
				}
			});
		}	

		
		newSelectColumn[0].firstChild.addEventListener('click', function(){
			isLeftChecked = true;
		});
	};
}

// SUBMIT THE CODE ABOVE THIS LINE

if (typeof module !== 'undefined') {
	module.exports = solve;
}
