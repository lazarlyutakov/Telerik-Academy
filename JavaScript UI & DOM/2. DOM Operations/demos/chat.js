let charWrapper = document.getElementById('chatWrapper');

function displayMsg(){
    let input = document.getElementById('inputMsg');

    let msg = document.createElement('div');
    msg.innerHTML = input.value;

    chatWrapper.appendChild(msg);
}

setInterval(displayMsg, 1000);