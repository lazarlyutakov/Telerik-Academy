function printElements(element, indent) {
    let spaces = '';
    for (let i = 0; i < indent; i += 1) {
        spaces += ' ';
    }

    if (element.tagName) {
        console.log(spaces + element.tagName);
    }
    for (let i = 0; i < element.childNodes.length; i += 1) {

        printElements(element.childNodes[i], indent + 1); //rekursiq
    }
}