let wrapper = document.getElementById('wrapper');

let counter = 0;

function addElement(){
    let newElement = document.createElement('div');
    counter += 1;
    newElement.innerHTML = counter + 'kor';
    newElement.id = 'added-div-' + counter;
    newElement.className = 'added';

    wrapper.appendChild(newElement);
}

function removeElement(){
    let elToRemove = document.getElementsByClassName('added')[0];
    elToRemove.style.color = 'red';
    setTimeout(function(){
        elToRemove.parentNode.removeChild(elToRemove);
    }, 500);
    
}

setInterval(addElement, 1000);

setInterval(removeElement, 1500);