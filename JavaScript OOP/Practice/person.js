/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */


'use strict';


class Person {
    constructor(firstname, lastname, age) {
        validateName(firstname);
        validateName(lastname);
        validateAge(age);
        this._firstname = firstname;
        this._lastname = lastname;
        this._age = age;

        return this;
    }

    get firstname() {
        return this._firstname;
    }
    set firstname(value) {
        this._firstname = value;
    }

    get lastname() {
        return this._lastname;
    }
    set lastname(value) {
        this._lastname = value;
    }

    get age() {
        return this._age;
    }
    set age(value) {
        this._age = value;
    }

    get fullname() {
        return this.firstname + ' ' + this.lastname;
    }
    set fullname(value) {
        let names = value.split(' ');
        this.firstname = value[0];
        this.lastname = value[1];
    }

    //Static method - not possible to create instance, being called through the class!
    static Introduce(fullname, age) {
        return console.log(`Hello! My name is ${fullname} and I am ${age} years old.`);
    }

    //Prototype method
    Introduce2(){
        return console.log(`Hello! My name is ${this.fullname} and I am ${this.age} years old.`);
    }
}

class Politik extends Person{
    constructor(firstname, lastname, age, corruptRank){
        super(firstname, lastname, age);
        this._corruptRank = corruptRank;

        return this;
    }

    get corruptRank(){
        return this._corruptRank;
    }

    Steal(){
        return console.log(`I, ${this.fullname}, stole a lot of money! My corrupt rank is ${this.corruptRank}.`);
    }
}


function validateName(name) {
    if (name.length < 3 || name.length > 20) {
        throw new Error('Enter a valid name!');
    }
    if (!name.match(/[A-Za-z]/)) {
        throw new Error('Name must consist of only latin characters!');
    }
    if (typeof name !== 'string') {
        throw new Error('Name must be a string!');
    }
}

function validateAge(age) {
    if (age.toString() === '' || age != Number(age)) {
        throw new Error('Age must be a valid number!');
    }

    age = +age;

    if (age < 0 || age > 150) {
        throw new Error('Enter a valid age!');
    }
}

let jj = new Person('Lazar', 'Lyutakov', 27);
jj.Introduce2();
Person.Introduce(jj.fullname, jj.age);
console.log(jj.fullname);

let lainar = new Politik('Barekov', 'Oligofren', 40, 10);

lainar.Steal();