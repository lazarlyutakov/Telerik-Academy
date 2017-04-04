

//star metod
console.log('Nachin dosega');
const getNextId = (function(){
    let counter = -1;

    return function(){
        counter += 1;
        return counter;
    };
}());

console.log(getNextId());
console.log(getNextId());
console.log(getNextId());

console.log('S generator funkcii : ');

