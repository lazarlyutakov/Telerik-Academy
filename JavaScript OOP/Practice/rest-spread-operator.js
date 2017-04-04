
console.log('REST OPERATOR');
//izkarva elementite ot masiva
//kogato e vlqvo ot ravnoto, e rest operator
function add(...args){
    console.log(args.reduce((x, y) => x + y, 0));
}

add(1, 6, 4, 3);

let arr = [1, 6, 4, 3];

const [first, ...rest]= arr;
//first vzima chisloto edno, a ...rest pravi masiv ot ostanalite
//...rest - rest operator
console.log(first);
console.log(rest);

console.log('Mahame pyrviat element na arr : ');
[, ...arr] = arr;
console.log(arr);

console.log();
console.log('=====================================');
console.log();

console.log('SPREAD OPERATOR : ');
//Ako ima mnogo neshta izredeni sys zapetaika, sloji gi v masiv
//obratnoto na rest operatora
//Spread e kogato go izpolzvame v expression, t.e. vdqsno ot ravnoto

function sumirai(){
    return Array.from(arguments)
                .reduce((x, y) => x + y, 0);
}

const masiv = [1, 2, 3];

console.log(sumirai(...masiv));


console.log('sumirane na masivi : ');
function arrSum(x, y, ...rest){
    return Array.from(arguments)
                .reduce((x, y) => x + y, 0);
}

const arr1 = [1, 2, 3];
const arr2 = [4, 5, 6];

const result = arrSum(...arr1, ...arr2);
console.log(result);


console.log('konkatenirane na masivi : ');
const arr3 = [1, 2, 3];
const arr4 = [4, 5, 6];

const result1 = [...arr1, ...arr2];
console.log(result1);


console.log('zakachane na stoinost : ');
const arr5 = [1, 2, 3];
let arr6 = [4, 5, 6];

arr6 = [7, ...arr6];
//sedmicata vliza pred chetvorkata v masiv arr6
arr6 = [...arr6, 8];
//osmicata otiva v kraq

const result2 = [...arr5, ...arr6];
console.log(result2);







