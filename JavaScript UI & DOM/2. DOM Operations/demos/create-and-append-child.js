let wrapper = document.getElementById('wrapper');

let counter = 0;

function addElement(){
    let newElement = document.createElement('div');
    counter += 1;
    newElement.innerHTML = counter + 'kor';
    newElement.id = 'added-div-' + counter;

    wrapper.appendChild(newElement);
}

setInterval(addElement, 1000);