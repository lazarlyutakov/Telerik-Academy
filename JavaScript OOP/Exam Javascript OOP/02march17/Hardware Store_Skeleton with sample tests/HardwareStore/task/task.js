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
			let price = this.price;
			return `SmartPhone - ${this.manufacturer} ${this.model} - **` + price + `**`;

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
			let price = this.price;
			return `Charger - ${this.manufacturer} ${this.model} - **` + price + `**`;

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
			let price = this.price;
			return `Router - ${this.manufacturer} ${this.model} - **` + price + `**`;

		}
	}

	class Headphones extends Product {
		constructor(manufacturer, model, price, quality, hasMicrophone) {
			super(manufacturer, model, price);
			this.quality = quality;
			if (hasMicrophone === true || hasMicrophone === 1) {
				this._hasMicrophone = true;
			}
			else if (hasMicrophone === false || hasMicrophone === 0 || hasMicrophone === null || hasMicrophone === undefined || hasMicrophone === '' || hasMicrophone === NaN) {
				this._hasMicrophone = false;
			}
			else {
				throw Error('invalid microphone input');
			}

		}

		get quality() {
			return this._quality;
		}
		set quality(quality) {
			if (typeof quality !== 'string' || !quality.match(/[min high low]/)) {
				throw Error('Invalid quality');
			}
			this._quality = quality;
		}

		get hasMicrophone() {
			return this._hasMicrophone;
		}


		getLabel() {
			let price = this.price;
			return `Headphones - ${this.manufacturer} ${this.model} - **` + price + `**`;

		}
	}

	class HardwareStore {
		constructor(name) {
			this.name = name;
			this.products = [];
			this._productsInStock = [];
		}

		get name() {
			return this._name;
		}
		set name(name) {
			if (typeof name !== 'string' || name.length < 1 || name.length > 20) {
				throw Error('Invalid HardwareStore name');
			}
			this._name = name;
		}

		get products() {
			return this._products;
		}
		set products(products) {
			this._products = products;
		}

		get productsInStock() {
			return this._productsInStock;
		}

		stock(product, quantity) {
			if (!(product instanceof Product)) {
				throw Error('Must be instance of Product');
			}
			if (typeof quantity !== 'number' || quantity <= 0 || ((quantity | 0) !== quantity) || Number.isNaN(quantity)) {
				throw Error('quantity must be number greater than 0');
			}

			this.products.push(product);

			for (let i = 0; i < quantity; i += 1) {
				this.productsInStock.push(product);
			}

			this.products.sort((x, y) => x.manufacturer.localeCompare(y.manufacturer))
                          .sort((x, y) => x.model.localeCompare(y.model))
                          .sort((x, y) => x.price - y.price);

			for (let i = 1; i < this.products.length; i += 1) {
				if (this.products[i].id === this.products[i - 1].id) {
					this.products.splice(i, 1);
				}
				else if(this.products[i].manufacturer === this.products[i - 1].manufacturer
					&& this.products[i].model === this.products[i - 1].model
					&& this.products[i].price === this.products[i - 1].price){
						
						this.products.splice(i, 1);
					}
			}


			return this;
		}

		sell(productId, quantity) {
			if (typeof quantity !== 'number' || quantity <= 0 || ((quantity | 0) !== quantity) || Number.isNaN(quantity)) {
				throw Error('quantity must be number greater than 0');
			}
			if (this.productsInStock.length < quantity) {
				throw Error('Not enough products');
			}
			this.products.forEach(el => {
				if (el.id !== productId) {
					throw Error('Such product does not exist');
				}
			});

			let index = this.productsInStock.findIndex(x => x.id === productId);


			if (index === -1) {
				throw Error('Product does not exist');
			}
			this.productsInStock.splice(index, quantity);

			if (this.productsInStock.length === 0) {
				this.products = this.products.splice();
			}

			return this;
		}

		getSold() {


		}

		search(options) {

			if (typeof options === 'string') {


				let result = [];
				let resultArr = [];
				let counter = 0;

				this.productsInStock.forEach(x => {
					if (x.model.toLowerCase().includes(options.toLowerCase()) || x.manufacturer.toLowerCase().includes(options.toLowerCase())) {
						counter += 1;
						result = {
							product: x.constructor.name,
							quantity: counter
						};
						resultArr.push(result);
					}
				});
				resultArr.reverse()
					.splice(1);

				return resultArr;
			}

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

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE
