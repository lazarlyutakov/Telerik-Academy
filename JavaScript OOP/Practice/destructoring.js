
//PRIMER 1
console.log('Primer Edno');
let person = {
    name : 'Kavalcho Kavalev',
    address : {
        city : 'Sofia',
        street : 'Solunska'
    },
    age : 42
};

const arr = [17, person, [4, 2]];

let[, {address:{city}}, [first]] = arr;

//17 se prenebregva ( bi trqbvalo da e v nachaloto na masiva, predi pyrvata zapetaika)
//{address : {city}} izpozlva obekta person
//first vzima chisloto 4 ot masiva, a ako v izraza beshe [, first], shteshe da vzeme 2, zashtoto 4 se prenebregva

console.log(first);
console.log(city);

console.log();
console.log('============================================');

//PRIMER 2
console.log('Primer Dve');

function add(arr){
    const [x, y] = arr;
    console.log(x + y);
}
add([5, 9,]);

console.log();

