

class Cat{
    constructor(name){
        this._name = name;
        this._silenced = false;
        this.age = 5;
    }

    meow(){
        if(this._silenced){
            return;
        }
        console.log(`${this._name} says meow!`);
    }

    silence(){
        this._silenced = true;
    }

    get age(){
        return this._age;
    }
    set age(newAge){
        if(newAge < 0){
            throw new Error('Age must be positive!');
        }
        this._age = newAge;
    }

    get name(){
        return this._name;
    }
    set name(x){
        throw new Error('Name cannot be changed!');
    }
}

const p = new Cat('Penka');

console.log(p.age);



function Dog(name){
    this._name = name;
    this._silenced = false;

    this.bark = function(){
         if(this._silenced){
            return;
        }
        console.log(`${this._name} says bark!`);
    }

    this.silence = function(){
        this._silenced = true;
    }
}

const d = new Dog('Sharo');
d.bark();
d.bark();
d.silence();