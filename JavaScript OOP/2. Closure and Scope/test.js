

function myFunction(x, y, z) {}
let args = [0, 1, 2];
myFunction(...args);

//console.log(myFunction.reduce((x, y) => x + y, 0));
console.log(myFunction.arguments);
for(let x of args){
    console.log(x);
}