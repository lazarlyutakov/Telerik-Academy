'use strict';

(function(){
    console.log('invoked');
}());

function mm(x, y, z){}

let args = [0, 1, 2];
mm(...args);

for(const x of args){
    console.log(x);
}


//console.log(sum([1, 2, 3, 4, 5, 6]));
//console.log(sum(['peter', ' ', 'ivanov'] ));