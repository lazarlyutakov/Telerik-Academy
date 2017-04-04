
function solve() {
    const getNextId = (function () {
        let counter = 0;
        return function () {
            counter += 1;
            return counter;
        };
    })();

    class Product {
        constructor(manufacturer, model, price) {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this._id = getNextId();
        }

        get id() {
            return this._id;
        }

        get manufacturer() {
            return this._manufacturer;
        }
        set manufacturer(manufacturer) {
            if (typeof manufacturer !== 'string' || manufacturer.length < 1 || manufacturer.length > 20) {
                throw Error('Invalid manufacturer');
            }
            this._manufacturer = manufacturer;
        }

        get model() {
            return this._model;
        }
        set model(model) {
            if (typeof model !== 'string' || model.length < 1 || model.length > 20) {
                throw Error('Invalid model');
            }
            this._model = model;
        }

        get price() {
            return this._price;
        }
        set price(price) {
            if (typeof price !== 'number' || price <= 0 || Number.isNaN(price)) {
                throw Error('Price must be number greater than 0');
            }
            this._price = price;
        }

        getLabel() {
            return this.manufacturer + ' ' + this.model + ' - **' + this.price + '**';

        }
    }

    class SmartPhone extends Product {
        constructor(manufacturer, model, price, screenSize, operatingSystem) {
            super(manufacturer, model, price);
            this.screenSize = screenSize;
            this.operatingSystem = operatingSystem;
        }

        get screenSize() {
            return this._screenSize;
        }
        set screenSize(screenSize) {
            if (typeof screenSize !== 'number' || screenSize <= 0 || Number.isNaN(screenSize)) {
                throw Error('screenSize must be number greater than 0');
            }
            this._screenSize = screenSize;
        }

        get operatingSystem() {
            return this._operatingSystem;
        }
        set operatingSystem(operatingSystem) {
            if (typeof operatingSystem !== 'string' || operatingSystem.length < 1 || operatingSystem.length > 10) {
                throw Error('Invalid operatingSystem');
            }
            this.this_operatingSystem = operatingSystem;
        }

        getLabel() {
            return 'SmartPhone - ' + super.getLabel();

        }
    }

    class Charger extends Product {
        constructor(manufacturer, model, price, outputVoltage, outputCurrent) {
            super(manufacturer, model, price);
            this.outputVoltage = outputVoltage;
            this.outputCurrent = outputCurrent;
        }

        get outputVoltage() {
            return this._outputVoltage;
        }
        set outputVoltage(outputVoltage) {
            if (typeof outputVoltage !== 'number' || outputVoltage < 5 || outputVoltage > 20 || Number.isNaN(outputVoltage)) {
                throw Error('Invalid outputVoltage');
            }
            this._outputVoltage = outputVoltage;
        }

        get outputCurrent() {
            return this._outputCurrent;
        }
        set outputCurrent(outputCurrent) {
            if (typeof outputCurrent !== 'number' || outputCurrent < 100 || outputCurrent > 3000 || Number.isNaN(outputCurrent)) {
                throw Error('Invalid outputCurrent');
            }
            this._outputCurrent = outputCurrent;
        }

        getLabel() {
            return 'Charger - ' + super.getLabel();

        }
    }

    class Router extends Product {
        constructor(manufacturer, model, price, wifiRange, lanPorts) {
            super(manufacturer, model, price);
            this.wifiRange = wifiRange;
            this.lanPorts = lanPorts;
        }

        get wifiRange() {
            return this._wifiRange;
        }
        set wifiRange(wifiRange) {
            if (typeof wifiRange !== 'number' || wifiRange <= 0 || Number.isNaN(wifiRange)) {
                throw Error('wifiRange must be number greater than 0');
            }
            this._wifiRange = wifiRange;
        }

        get lanPorts() {
            return this._lanPorts;
        }
        set lanPorts(lanPorts) {
            if (typeof lanPorts !== 'number' || lanPorts <= 0 || ((lanPorts | 0) !== lanPorts) || Number.isNaN(lanPorts)) {
                throw Error('lanPorts must be number greater than 0');
            }
            this._lanPorts = lanPorts;
        }

        getLabel() {
            return 'Router - ' + super.getLabel();

        }
    }

    class Headphones extends Product {
        constructor(manufacturer, model, price, quality, hasMicrophone) {
            super(manufacturer, model, price);

            if (quality !== 'high' && quality !== 'mid' && quality !== 'low') {
                throw '';
            }

            this._quality = quality;
            this._hasMicrophone = !!hasMicrophone;
        }

        get quality() {
            return this._quality;
        }

        get hasMicrophone() {
            return this._hasMicrophone;
        }

        getLabel() {
            return 'Headphones - ' + super.getLabel();
        }
    }

    class HardwareStore {
        constructor(name) {
            if (typeof name !== 'string' || name.length < 1 || name.length > 20) {
                throw Error('Invalid HardwareStore name');
            }
            this._name = name;
            this._products = [];
            this._productsInStock = {};
            this._sold = 0;
        }

        get name() {
            return this._name;
        }

        get products() {
            return this._products.slice();
        }


        stock(product, quantity) {
            if(!(product instanceof Product)){
                throw Error('Must be instance of Product');
            }
            if (typeof quantity !== 'number' || quantity <= 0 || ((quantity | 0) !== quantity) || Number.isNaN(quantity)) {
				throw Error('quantity must be number greater than 0');
			}

            if(!this._productsInStock[product.id]){
                this._products.push(product);
                this._productsInStock[product.id] = {product, quantity};
            }
            else{
                this._productsInStock[product.id].quantity += quantity;
            }
            return this;

        }

        sell(productId, quantity) {
            if (typeof quantity !== 'number' || quantity <= 0 || ((quantity | 0) !== quantity) || Number.isNaN(quantity)) {
				throw Error('quantity must be number greater than 0');
			}

            const inStock = this._productsInStock[productId];

            if(!inStock){
                throw Error('Such product does not exist');

            }
            if(inStock.quantity < quantity){
                throw Error('Not enough products');
            }

            inStock.quality -= quantity;
            this._sold += inStock.product.price * quantity;

            if(inStock.quantity === 0){
                this._productsInStock[productId] = false;
                const ind = this._products.findIndex(x => x.id === productId);
                this._products.splice(index, 1);
            }
            return this;

        }

        getSold() {
            return this._sold;


        }

        search(options) {


        }


    }

    return {
        getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
            return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
        },
        getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
            return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
        },
        getRouter(manufacturer, model, price, wifiRange, lanPorts) {
            return new Router(manufacturer, model, price, wifiRange, lanPorts);
        },
        getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
            return new Headphones(manufacturer, model, price, quality, hasMicrophone);
        },
        getHardwareStore(name) {
            return new HardwareStore(name);
        }
    };
}


let telefon = new SmartPhone('iphone', 'i7sa', 1000, 5, 'ios');
let telefon2 = new SmartPhone('HTC', 'M8', 900, 5, 'android');
let telefon3 = new SmartPhone('HTC', 'M9', 900, 5, 'android');
let telefon4 = new SmartPhone('HTC', 'M8', 900, 5, 'android');

let charger = new Charger('Lenovo', 'pstr', 50, 12, 302);
let charger2 = new Charger('Lenovo', 'pstr', 50, 12, 302);
let charger3 = new Charger('Lenovo', 'pstr', 50, 12, 302);
let ruter = new Router('TPlink', 'yu-89', 30, 10, 2);
let slushalki = new Headphones('Sony', 'mn nov', 100, 'mid', true);

let magazin = new HardwareStore('very');

magazin.stock(slushalki, 3);
magazin.stock(slushalki, 3);
magazin.stock(slushalki, 3);
magazin.stock(slushalki, 3);

magazin.stock(telefon, 5);
magazin.stock(telefon2, 2);
magazin.stock(telefon2, 2);
magazin.stock(telefon3, 2);
magazin.stock(telefon4, 2);
magazin.stock(charger, 3);
magazin.stock(charger2, 2);
magazin.stock(charger3, 3);

//magazin.sell(slushalki.id, 3);

console.log(magazin.products);

// let kk = magazin.search('ht');
// console.log(kk);




