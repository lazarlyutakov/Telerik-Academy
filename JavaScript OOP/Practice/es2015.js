

const names = new Set();

names.add('cuki');
names.add('cuki');
names.add('cuki');
names.add('doncho');

for(const x of names){
    console.log(x);
}

let numbers = [2, 3, 4, 6, 7, 2, 5, 65, 2];

let output = numbers.sort((x, y) => y - x);
const hh = numbers.filter(x => x > 5)
                   .map(x => x+10);
console.log(output);
console.log(hh);

console.log();
console.log('=================');
console.log();

console.log('ARRAY FROM EXAMPLE : ');

const arr = Array.from({length : 10}).map(() => '3 kura');

for(const x of arr){
    console.log(x);
}


//Syzdava masiv ot array-like obekt;
//Ako nqmashe .from, nqmashe da raboti
function sum(){
    return Array.from(arguments).reduce((x, y) => x + y, 0);
}

console.log(sum(4, 5, 8, 7));

