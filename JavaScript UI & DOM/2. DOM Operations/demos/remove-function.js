
//za foruma na telerik
function remove(){
    var el = document.getElementsByTagName('h3')[0];
    el.parentNode.removeChild(el);
}

setInterval(remove, 1000);