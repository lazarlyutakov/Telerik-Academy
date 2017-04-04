

class Person{
    constructor(name, age){
        this._name = name;
        this._age = age;
    }

}

function getPerson(name, age){
    return{
        sayHello(){
            console.log(`Hi, my name is ${name} and I am ${age}`);
        }
    };
}




let p = new Person('ddd', 20);

console.log(p);
