function solve() {

	const getNextId = (function () {
		let counter = 0;
		return function () {
			counter += 1;
			return counter;
		};
	}());

	class Item {
		constructor(name, description) {
			this.name = name;
			this.description = description;

			this._id = getNextId();
		}

		get id() {
			return this._id;
		}

		get name() {
			return this._name;
		}
		set name(name) {
			if (typeof name !== 'string' || name.length < 2 || name.length > 40) {
				throw new Error('Invalid name : must be string between 2 and 40 characters!');
			}
			this._name = name;
		}

		get description() {
			return this._description;
		}
		set description(description) {
			if (typeof description !== 'string' || description === '') {
				throw new Error('Description must be non empty string!');
			}
			this._description = description;
		}


	}

	class Book extends Item {
		constructor(name, description, isbn, genre) {
			super(name, description);
			this.isbn = isbn;
			this.genre = genre;
		}

		get isbn() {
			return this._isbn;
		}
		set isbn(isbn) {
			if (typeof isbn !== 'string') {
				throw new Error('Isbn must be a string!');
			}
			if (isbn.length !== 10 && isbn.length !== 13) {
				throw new Error('Isbn must be between 10 and 13 chars long!');
			}
			this._isbn = isbn;
		}

		get genre() {
			return this._genre;
		}
		set genre(genre) {
			if (typeof genre !== 'string' || genre.length < 2 || genre.length > 20) {
				throw new Error('Invalid genre : must be string between 2 and 20 characters!');
			}
			this._genre = genre;
		}
	}

	class Media extends Item {
		constructor(name, description, duration, rating) {
			super(name, description);
			this.duration = duration;
			this.rating = rating;
		}

		get duration() {
			return this._duration;
		}
		set duration(duration) {
			if (typeof duration !== 'number' || duration <= 0) {
				throw new Error('Duration must be a number greater than zero!');
			}
			this._duration = duration;
		}

		get rating() {
			return this._rating;
		}
		set rating(rating) {
			if (typeof rating !== 'number' || rating < 1 || rating > 5) {
				throw new Error('Rating must be a number between 1 and 5 inclusive!');
			}
			this._rating = rating;
		}
	}

	class Catalog {
		constructor(name) {
			this._id = getNextId();
			this.name = name;
			this.items = [];
		}

		get id() {
			return this._id;
		}

		get name() {
			return this._name;
		}
		set name(name) {
			if (typeof name !== 'string' || name.length < 2 || name.length > 40) {
				throw new Error('Invalid name : must be string between 2 and 40 characters!');
			}
			this._name = name;
		}

		add(...items) {
			if (Array.isArray(items[0])) {
				items = items[0];
			}

			if (items.length === 0) {
				throw new Error('There is nothing to add');
			}

			this.items.push(...items);

			return this;
		}

		find(input) {
			if (typeof input === 'number') {
				for (let element of this.items) {
					if (element.id === input) {
						return element;
					}
				}
				return null;
			}

			if (input !== null && typeof input === 'object') {
				return this.items.filter(function (el) {
					return Object.keys(input).every(function (pr) {
						return input[pr] === el[pr];
					});
				});
			}
			throw new Error('Invalid input');
		}


		search(pattern) {
			if (typeof pattern !== 'string' || pattern.length < 1) {
				throw new Error('Pattern is not valid!');
			}
			return this.items.filter(x => x._name === pattern || x._description === pattern);
			// for (let element of this.items) {
			// 	if (pattern === element.name || pattern === element.description) {
			// 		return this.items.filter(x => pattern === x.name || pattern === x.description);
			// 	}
			// 	else {
			// 		return [];
			// 	}
			//}
		}
	}


	class BookCatalog extends Catalog {
		constructor(name) {
			super(name);
		}

		add(...books) {
			if (Array.isArray(books[0])) {
				books = books[0];
			}

			books.forEach(function (x) {
				if (!(x instanceof Book)) {
					throw 'Must add only books';
				}
			});

			return super.add(...books);
		}

		getGenres() {
			let genresArray = [];

			for(let el of this.items){
				genresArray.push(el.genre.toLowerCase());
			}

			let uniqueTypes = new Set(genresArray);

			let result = Array.from(uniqueTypes);

			return result;
		}

		find(options) {
			return super.find(options);

		}
	}

	class MediaCatalog extends Catalog {
		constructor(name) {
			super(name);
		}

		add(...items) {

		}

		getTop(count) {

		}

		getSortedByDuration() {

		}

		find(options) {

		}
	}


	return {
		getBook: function (name, isbn, genre, description) {
			return new Book(name, description, isbn, genre);
		},
		getMedia: function (name, rating, duration, description) {
			return new Media(name, description, duration, rating);
		},
		getBookCatalog: function (name) {
			return new BookCatalog(name);
		},
		getMediaCatalog: function (name) {
			return new MediaCatalog(name);
		}
	};
}

module.exports = solve;



