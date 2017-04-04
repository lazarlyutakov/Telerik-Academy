/* globals module */

"use strict";

function solve() {

    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
        }

        get productType() {
            return this._productType;
        }
        set productType(productType) {
            if (typeof productType !== 'string') {
                throw new Error('Product Type must be a string !');
            }
            this._productType = productType;
        }

        get name() {
            return this._name;
        }
        set name(name) {
            if (typeof name !== 'string') {
                throw new Error('Name must be a string!');
            }
            this._name = name;
        }

        get price() {
            return this._price;
        }
        set price(price) {
            if (typeof price !== 'number') {
                throw new Error('Price must be a number!');
            }
            this._price = price;
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
            if (!Array.isArray(products)) {
                throw new Error('Products must be an array');
            }
            this._products = products;
        }

        add(product) {
            this.products.push(product);

            return this;

        }

        remove(product) {
            if (this.products.length === 0) {
                throw new Error('There are no products in the array!');
            }

            const indexOfProduct = this.products.findIndex(pr => pr.name === product.name &&
                pr.price === product.price &&
                pr.productType === product.productType);
            if (indexOfProduct === -1) {
                throw new Error('Product does no exist!');
            }
            return this.products.splice(indexOfProduct, 1);

        }

        showCost() {
            if (this.products.length === 0) {
                return 0;
            }

            return this.products.reduce((x, y) => x + y.price, 0);
            //    let result = 0;

            //    for(let i = 0; i < this.products.length ; i += 1) {
            //        result += this.products[i].price;

            //    }
            //    return result;

        }

        showProductTypes() {
            if (this.products.length === 0) {
                return [];
            }

            let result = this.products.map(p => p.productType)
                .sort();
            result = new Set(result);

            return Array.from(result);
        }

        getInfo() {
            const groupedByName = {};

            this.products.forEach(p => {
                if (groupedByName.hasOwnProperty(p.name)) {
                    groupedByName[p.name].quantity += 1;
                    groupedByName[p.name].totalPrice += p.price;
                }
                else {
                    groupedByName[p.name] = {
                        name: p.name,
                        quantity: 1,
                        totalPrice: p.price
                    };
                }
            });

            const groups = Object.keys(groupedByName)
                .sort()
                .map(n => {
                    return {
                        name: n,
                        quantity: groupedByName[n].quantity,
                        totalPrice: groupedByName[n].totalPrice
                    };
                });

            return {
                //products: Object.values(groupedByName).sort(x => x.name),
                products: groups,
                totalPrice: this.showCost()
            }
        }
    }


    return {
        Product: Product,
        ShoppingCart: ShoppingCart
    };

}

module.exports = solve;


