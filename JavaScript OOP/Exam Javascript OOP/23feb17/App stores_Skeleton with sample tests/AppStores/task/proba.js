

	class App {
		constructor(name, description, version, rating) {
			if (typeof name !== 'string' || name.length < 1 || name.length > 24 || name.match(/[^a-zA-Z0-9 ]/)) {

				throw Error('Invalid name input!');
			}
			this.name = name;

			if (typeof description !== 'string') {
				throw Error('Description must be a string!');
			}
			this.description = description;

			if (typeof version !== 'number' || version <= 0) {
				throw Error('Version must be a positive number');
			}
			this.version = version;

			if (typeof rating !== 'number' || rating < 1 || rating > 10) {
				throw Error('Rating must be a number between 1 and 10!');
			}
			this.rating = rating;
		}

		get name() {
			return this._name;
		}
		set name(name) {

			this._name = name;
		}

		get description() {
			return this._description;
		}
		set description(description) {

			this._description = description;
		}

		get version() {
			return this._version;
		}
		set version(version) {

			this._version = version;
		}

		get rating() {
			return this._rating;
		}
		set rating(rating) {

			this._rating = rating;
		}

		release(options) {
			for (let key in options) {
				let value = options[key];

				if (key === 'version') {
					if (value < this.version) {
						throw Error('Not newer than current one!');
					}
					if (typeof value !== 'number' || value < 0) {
						throw Error('Version must be a positive number');
					}
					if (value === undefined) {
						throw Error('Must be defined');
					}
					this.version = value;
				}

				if (key === 'description') {
					if (typeof value !== 'string') {
						throw Error('Must be a string');
					}
					this.description = value;
				}

				if (key === 'rating') {
					if (typeof value !== 'number' || value < 1 || value > 10) {
						throw Error('value must be a number between 1 and 10!');
					}
					this.rating = value;

				}
			}

		}
	}

	class Store extends App {
		constructor(name, description, version, rating) {
			super(name, description, version, rating);

			this.apps = [];
		}

		get apps() {
			return this._apps;
		}
		set apps(apps) {
			this._apps = apps;
		}

		upload(app) {
			if (!(app instanceof App)) {
				throw Error('App must be an instance of App class!');
			}
			if (this.apps.length === 0) {
				this.apps.push(app);
			}

			for (let i = 0; i < this.apps.length; i += 1) {

				if (this.apps[i].name !== app.name) {
					this.apps.push(app);
				}
				if (this.apps[i].name === app.name) {
					app.release(app);
					if (app.version < this.apps[i].version) {
						throw Error('Version is not newer!');
					}
					this.apps[i].version = app.version;
				}
			}
			return this;
		}

		takedownApp(name) {
			const index = this.apps.findIndex(i => i.name === name);
			if (index === -1) {
				throw Error('Not existing!');
			}
			this.apps.splice(index, 1);

			return this;
		}

		search(pattern) {
			return this.apps.filter(x => x.name.toLowerCase().includes(pattern.toLowerCase()))
				.sort((x, y) => x.name.localeCompare(y.name));

		}

		listMostRecentApps(count) {

		}

		listMostPopularApps(count) {
			return this.apps.sort((x, y) => y.rating - x.rating)
				.splice(0, count);

		}
	}

	class Device {
		constructor(hostname, appsD) {
			if (typeof hostname !== 'string' || hostname.length < 1 || hostname.length > 32) {
				throw Error('Hostname is a string between 1 and 32 chars!');
			}
			this._hostname = hostname;

			// for (let i = 0; i < apps.length; i += 1) {
			// 	if (!(apps[i] instanceof App)) {
			// 		throw Error('Not valid');
			// 	}
			// }
			let store = new Store(this.name, this.description, this.version, this.rating);
			//let store = new Store(this.apps.name, this.apps.description, this.apps.version, this.apps.rating);

			this.appsD = new Store(appsD.name, appsD.description, appsD.version, appsD.rating);
			//this.appsD = this.apps;
			this.installedStores = [];
		}

		get hostname() {
			return this._hostname;
		}
		set hostname(hostname) {
			this._hostname = hostname;
		}

		get appsD() {
			return this._appsD;
		}
		// set appsD(appsD) {
		// 	this._appsD = appsD;
		// }

		get installedStores() {
			return this._installedStores;
		}
		set installedStores(installedStores) {
			this._installedStores = installedStores;
		}

		installStore(store) {
			if (!(store instanceof Store)) {
				throw Error('Must be a Store instance');
			}
			this.installedStores.push(store);

			return this;
		}

		search(pattern) {
			let result = [];

			for (let element of this.installedStores) {
				if (element.name.toLowerCase().includes(pattern.toLowerCase())) {
					let answer = element.name;
					result.push(answer);
				}
			}

			return result.sort((x, y) => x.name.localeCompare(y.name))
				.filter((x, y) => {
					if (x.name === y.name) {
						return x.version > y.version;
					}
				});
		}

		install(name) {
			let len = this.installedStores.length;

			for(let i = 0; i < len ; i += 1) {
				if (installedStores[i].name !== name){
					throw new Error('No such app exists!');

				}

				 this.installedStores.filter((x, y) => {
					if (x.name === y.name) {
						return x.version > y.version;
					}
				});

				for(let i = 0; i < len ; i += 1) {
					if(this.installedStores[i].name === name){
						return;
					}
					this.appsD.push(installedStores[i]);				
				}			
			}
		}

		uninstall(name) {

		}

		listInstalled() {

		}

		update() {

		}
	}





let app = new App('name', 'very good', 2, 5);
let app2 = new App('zzame', 'very', 5, 6);
let app3 = new App('name2', 'very goooood', 6, 9);
let app4 = new App('namwrgre2', 'goooood', 7, 8);
let app5 = new App('nddvbame2', 'very god', 4, 6);
let app6 = new App('namfbebe2', 've', 5, 2);

let store = new Store('magazin', 'chuden magazin', 2, 3);
store.upload(app);
store.upload(app2);
store.upload(app3);
store.upload(app4);
store.upload(app5);
store.upload(app6);

let device = new Device('ustroistvoto', []);


console.log(store.apps);