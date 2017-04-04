

	function copyApp(app) {
		return {
			name: app.name,
			description: app.description,
			version: app.version,
			rating: app.rating,
			apps: app.apps
		};
	}

	class App {
		constructor(name, description, version, rating) {
			if (typeof name !== 'string' || name.length < 1 || name.length > 24 || name.match(/[^a-zA-Z0-9 ]/)) {

				throw Error('Invalid name input!');
			}
			this._name = name;

			if (typeof description !== 'string') {
				throw Error('Description must be a string!');
			}
			this._description = description;

			if (typeof version !== 'number' || version <= 0 || Number.isNaN(version)) {
				throw Error('Version must be a positive number');
			}
			this._version = version;

			if (typeof rating !== 'number' || rating < 1 || rating > 10 || Number.isNaN(version)) {
				throw Error('Rating must be a number between 1 and 10!');
			}
			this._rating = rating;
		}

		get name() {
			return this._name;
		}

		get description() {
			return this._description;
		}

		get version() {
			return this._version;
		}

		get rating() {
			return this._rating;
		}

		release(options) {
			if (typeof options !== 'object') {
				options = { version: options };
			}

			if (typeof options.version !== 'number' || options.version <= 0 || Number.isNaN(options.version)) {
				throw Error('Version must be a positive number');
			}
			if ((options.version <= this._version)) {
				throw Error('Invalid version');
			}
			this._version = options.version;

			if (options.hasOwnProperty('description')) {
				if (typeof options.description !== 'string') {
					throw Error('Must be a string');
				}
				this._description = options.description;
			}

			if (options.hasOwnProperty('rating')) {
				if (typeof options.rating !== 'number' || options.rating < 1 || options.rating > 10) {
					throw Error('value must be a number between 1 and 10!');
				}
				this._rating = options.rating;
			}
		}
	}

	class Store extends App {
		constructor(name, description, version, rating) {
			super(name, description, version, rating);

			this._apps = [];
		}

		get apps() {
			return this._apps;
		}


		uploadApp(app) {
			if (!(app instanceof App)) {
				throw Error('App must be an instance of App class!');
			}

			const index = this._apps.findIndex(x => x.name === app.name);
			if (index >= 0) {
				this._apps.splice(index, 1);
			}
			this._apps.push(copyApp(app));

			return this;
		}

		takedownApp(name) {
			const index = this._apps.findIndex(i => i.name === name);
			if (index === -1) {
				throw Error('Not existing!');
			}
			this._apps.splice(index, 1);

			return this;
		}

		search(pattern) {
			return this.apps.filter(x => x.name.toLowerCase().includes(pattern.toLowerCase()))
				.sort((x, y) => x.name.localeCompare(y.name));

		}

		listMostRecentApps(count) {

			count = count || 10; //default value = 10;

			return this._apps.slice()
				.reverse()
				.slice(0, count);

		}

		listMostPopularApps(count) {
			count = count || 10;

			return this._apps.map((app, index) => ({ app, index }))
				.sort((x, y) => {
					if (y.app.rating !== x.app.rating) {
						return y.app.rating - x.app.rating;
					}
					return y.app.index - x.app.index;
				})
				.slice(0, count)
				.map(x => x.app);
		}
	}

	class Device {
		constructor(hostname, apps) {
			if (typeof hostname !== 'string' || hostname.length < 1 || hostname.length > 32) {
				throw Error('Hostname is a string between 1 and 32 chars!');
			}

			if (!Array.isArray(apps)) {
				throw Error('Apps must be an array of apps');
			}
			if (!apps.every(x => x instanceof App)) {
				throw Error('There is non-app in the apps array');
			}

			this._hostname = hostname;
			this._apps = apps.map(x => copyApp(x));
			this._stores = apps.filter(x => x instanceof Store).map(x => copyApp(x));

		}

		get hostname() {
			return this._hostname;
		}


		get apps() {
			return this._apps.slice();
		}

		search(pattern) {
			pattern = pattern.toLowerCase();

			const result = {};

			this._stores.forEach(store => {
				store.apps.forEach(x => {
					if (x.name.toLowerCase().indexOf(pattern) < 0) {
						return;
					}
					if (result.hasOwnProperty(x.name) && x.version <= result[x.name].version) {
						return;
					}
					result[x.name] = x;
				});
			});
			return Object.keys(result).sort()
				.map(key => result[key]);
		}

		install(name) {
			let bestApp = { version: -1 };

			this._stores.forEach(store => {
				const currApp = store.apps.find(x => x.name === name);
				if (currApp && bestApp.version < currApp.version) {
					bestApp = currApp;
				}
			});

			if (bestApp.version < 0) {
				throw Error('Error app not found!');
			}

			if (this._apps.every(x => x.name !== name)) {
				this._apps.push(copyApp(bestApp));
				if (bestApp instanceof Store) {
					this._stores.push(copyApp(bestApp));
				}
			}
			return this;
		}

		uninstall(name) {
			let index = this._apps.findIndex(x => x.name === name);
			if(index < 0){
				throw Error('App is not installed');
			}
			this._apps.splice(index, 1);

			index = this._stores.findIndex(x => x.name === name);
			if(index >= 0){
				this._stores.splice(index, 1);
			}
			return this;
		}

		listInstalled() {
			return (this._apps.slice()
			                .sort((x, y) => x.name.localeCompare(y.nama)));
		}

		update() {
			this._apps = this._apps.map(app => {
				const name = app.name;

				let bestApp = app;
				this._stores.forEach(store => {
					const currApp = store.apps.find(x => x.name === name);
					if(currApp && bestApp.version < currApp.version){
						bestApp = currApp;
					}
				});
				return bestApp;
			});
			return this;

		}
	}

let store = new Store('magazin', 'denonoshten', 2, 3);

let app = new App('prilojenie', 'moderno', 4, 5);

store.uploadApp(app);
app.release(7);
store.uploadApp(app);

console.log(store.apps);
