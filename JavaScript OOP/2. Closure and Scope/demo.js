'use strict';

let arr = [2, 5, 8, 1, 4, 12];


function isBiggerThan10(element, index, array) {
  return element > 10;
}


function calc(array){
    
    if(array.any(isBiggerThan10)){
        throw 'Nema da stane';
    }

    return array.reduce((x, y) => (+x) + (+y));
}


arr.some(isBiggerThan10);  // false


console.log(arr.some(isBiggerThan10));
console.log(calc(arr));