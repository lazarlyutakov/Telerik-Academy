/* globals module */

"use strict";


const validateIfString = function (str) {
    if (typeof str !== 'string') {
        throw Error('Your input must be a string');
    }
};

const validateIfNumber = function (numb) {
    if (typeof numb !== 'number') {
        throw Error('Must be a number');
    }
}

class Product {
    constructor(productType, name, price) {
        validateIfString(productType);
        validateIfString(name);
        validateIfNumber(price);

        this.productType = productType;
        this.name = name;
        this.price = price;
    }

    get productType() {
        return this._productType;
    }
    set productType(productType) {
        this._productType = productType;
    }

    get name() {
        return this._name;
    }
    set name(name) {
        this._name = name;
    }

    get number() {
        return this._number;
    }
    set number(number) {
        this._number = number;
    }

}


class ShoppingCart {
    constructor() {

        this.products = [];
    }

    get products() {
        return this._products;
    }
    set products(products) {
        if (!(Array.isArray(products))) {
            throw Error('Products must be an array');
        }
        this._products = products;
    }

    add(product) {
        this.products.push(product);

        return this;
    }

    remove(product) {
        if (this.products.length < 1) {
            throw Error('Shopping cart is empty');
        }

        const index = this.products.findIndex(x => x.productType === product.productType && x.name === product.name && x.price === product.price);

        if (index < 0) {
            throw Error('Item not found');
        }
        return this.products.splice(index, 1);

    }

    showCost() {
        if (this.products.length < 1) {
            return 0;
        }

        let result = 0;

        for (let element of this.products) {
            result += element.price;
        }

        return result;

    }

    showProductTypes() {
        if (this.products.length < 1) {
            return [];
        }

        let sortedArray = this.products.sort((x, y) => x.productType.localeCompare(y.productType));

        let resultArray = [];

        for (let element of this.products) {
            if (resultArray.indexOf(element.productType) < 0) {
                resultArray.push(element.productType);

            }
        }

        return resultArray;
    }

    getInfo() {

        let sortedByName = {};

        this.products.forEach(x => {
            if (sortedByName.hasOwnProperty(x.name)) {
                sortedByName[x.name].quantity += 1;
                sortedByName[x.name].totalPrice += x.price;
            }
            else {
                sortedByName[x.name] = {
                    name: x.name,
                    quantity: 1,
                    totalPrice: x.price
                };
            }
        });

        const productsGrouped = Object.keys(sortedByName).sort()
            .map(x => {
                return {
                    name: x,
                    quantity: sortedByName[x].quantity,
                    totalPrice: sortedByName[x].totalPrice
                };
            });

        return {
            products: productsGrouped,
            totalPrice: this.showCost()
        };

    }
}

let pr = new Product('kur', 'golem', 10);
let pr1 = new Product('kur', 'rqzan', 15);
let pr2 = new Product('hui', 'kosmat', 40);
let pr3 = new Product('chep', 'cheren', 14);
let pr4 = new Product('kur', 'malyk', 18);
let pr5 = new Product('pishak', 'ogromna', 30);

let shc = new ShoppingCart();

shc.add(pr);
shc.add(pr1);
shc.add(pr2);
shc.add(pr3);
shc.add(pr4);
shc.add(pr5);

console.log(shc.getInfo());

