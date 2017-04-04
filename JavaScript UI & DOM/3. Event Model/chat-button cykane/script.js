let bb = document.getElementById('button');

let container = document.getElementById('msg-container');
let input = document.getElementById('input');


function sendMessage() {
    let msg = input.value;

    input.value = '';

    let msgLine = document.createElement('p');
    msgLine.innerText = msg;

    if(msg === 'kor'){
        msgLine.style.fontSize = '20px';
        msgLine.style.color = 'red';
        msgLine.style.fontWeight = 'bold';
    }

    let timeEl = document.createElement('span');
    timeEl.innerHTML = (new Date() + ' ').split(' ')[4];
    timeEl.style.cssFloat = 'right';
    timeEl.style.fontSize = '8px';
    timeEl.style.fontWeight = 'bold';
    msgLine.appendChild(timeEl);

    container.appendChild(msgLine);
    container.scrollTop += 42;
}

input.addEventListener('keydown', function (e) {
    if (e.keyCode === 13) {
        sendMessage();
    }
});

bb.addEventListener('click', function(){
    sendMessage();
})



function changeInputbackground() {
    input.addEventListener('mouseover', function () {
        input.style.backgroundColor = 'aliceblue';
    });
    input.addEventListener('mouseout', function(){
        input.style.backgroundColor = 'white';
    }); 
}

function changeContainerbackground() {
    container.addEventListener('mouseover', function () {
        container.style.backgroundColor = 'blanchedalmond';
    });
    container.addEventListener('mouseout', function(){
        container.style.backgroundColor = 'white';
    }); 
}


//Igra s butona
function getBigger() {
    bb.addEventListener('mouseover', function () {
        bb.style.width = '400px';
        bb.style.fontSize = '38px';
        bb.style.borderRadius = '20px';
        bb.style.backgroundColor = 'lightpink';
        bb.innerHTML = 'Бегай, педал!';
    });

    getSmaller();
}

function getSmaller() {
    bb.addEventListener('mouseout', function () {
        bb.style.width = '200px';
        bb.style.fontSize = '20px';
        bb.style.color = 'seagreen';
        bb.style.borderRadius = '5px';
        bb.style.backgroundColor = 'yellow';
        bb.innerHTML = 'Click me!';
    });
}

getBigger();
changeInputbackground();
changeContainerbackground();



