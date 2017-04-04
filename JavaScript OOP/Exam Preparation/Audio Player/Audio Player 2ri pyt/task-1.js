function solve() {

	const getNextId = (function () {
		let counter = 0;
		return function () {
			counter += 1;
			return counter;
		};
	})();

	const getNextIdPlayable = (function () {
		let counter = 0;
		return function () {
			counter += 1;
			return counter;
		};
	})();

	const validateStringProperty = function (str) {
		if (typeof str !== 'string' || str.length < 3 || str.length > 25) {
			throw Error('Invalid string input');
		}
	};

	const validateAudioLength = function (len) {
		if (typeof len !== 'number' || len <= 0) {
			throw Error('Length is a number greater than 0');
		}
	};

	const validateImdbRating = function (imdb) {
		if (typeof imdb !== 'number' || imdb < 1 || imdb > 5) {
			throw Error('Invalid Imdb rating input');
		}
	}

	class Player {
		constructor(name) {
			validateStringProperty(name);
			this._name = name;

			this._playerContainer = [];
		}

		get name() {
			return this._name;
		}

		get playerContainer() {
			return this._playerContainer;
		}

		addPlaylist(playlistToAdd) {
			if (!(playlistToAdd instanceof PlayList)) {
				throw Error('Input value must be instance of PlayList class');
			}

			this._playerContainer.push(playlistToAdd);

			return this;
		}

		getPlaylistBy(id) {
			return this.playerContainer.find(x => x.id === id) || null;
		}

		removePlaylist(playlisy) {
			if (typeof playlist === 'number') {
				let index = this.playerContainer.findIndex(x => x.id === playlist);

				if (index === -1) {
					throw Error('Such playList does not exist');
				}

				return this.playerContainer.splice(index, 1);
			}

			if (typeof playlist === 'object') {
				let index = this.playerContainer.findIndex(x => x.id === playlist.id);

				if (index === -1) {
					throw Error('Such playList does not exist');
				}

				return this.playerContainer.splice(index, 1);
			}

		}

		listPlaylist(page, size) {
			if (typeof page !== 'number' || typeof size !== 'number' || page < 0 || size <= 0 || page * size >= this.playerContainer.length) {
				throw Error('Invalid page or size');
			}

			return this.playerContainer.sort((x, y) => x.name.localeCompare(y.name))
				.sort((x, y) => x.id - y.id);

		}

		contains(playable, playlist) {
			let index = playlist.playListCont.find(x => x.title === playable.title && x.author === playable.author && x.id === playable.id);

			if (index === undefined) {
				return false;
			}
			else {
				return true;
			}
		}

		search(pattern) {
		let result = {};
		let resultArr = [];


		this.playerContainer.forEach(list => {
			list.playListCont.forEach(el => {
				if (el.title.includes(pattern)) {
					result = {
						name: list.name,
						id: list.id
					};
					resultArr.push(result);
				}
			});
		});
		for (let i = 1; i <= resultArr.length - 1; i += 1) {
			if (resultArr[i].id === resultArr[i - 1].id) {
				resultArr.splice(i, 1);
			}
		}
		return resultArr;

		}
	}

	class PlayList {
		constructor(name) {
			validateStringProperty(name);
			this._name = name;
			this._id = getNextId();

			this._playListCont = [];
		}

		get id() {
			return this._id;
		}

		get name() {
			return this._name;
		}

		get playListCont() {
			return this._playListCont;
		}

		addPlayable(playable) {

			this.playListCont.push(playable);

			return this;

		}

		getPlayableById(id) {
			return this.playListCont.find(x => x.id === id) || null;

		}

		removePlayable(playable) {
			if (typeof playable === 'number') {
				let index = this.playListCont.findIndex(x => x.id === playable);

				if (index === -1) {
					throw Error('Such playable does not exist');
				}

				return this.playListCont.splice(index, 1);
			}

			if (typeof playable === 'object') {
				let index = this.playListCont.findIndex(x => x.id === playable.id);

				if (index === -1) {
					throw Error('Such playable does not exist');
				}

				return this.playListCont.splice(index, 1);
			}

		}

		listPlayables(page, size) {
			if (typeof page !== 'number' || typeof size !== 'number' || page < 0 || size <= 0 || page * size >= this.playListCont.length) {
				throw Error('Invalid page or size');
			}

			return this.playListCont.sort((x, y) => x.title.localeCompare(y.title))
				.sort((x, y) => x.id - y.id);

		}
	}

	class Playable {
		constructor(title, author) {
			validateStringProperty(title);
			validateStringProperty(author);
			this._title = title;
			this._author = author;

			this._id = getNextId();
		}

		get title() {
			return this._title;
		}

		get author() {
			return this._author;
		}

		get id() {
			return this._id;
		}

		play() {
			return `[${this.id}]. [${this.title}] - [${this.author}]`;

		}
	}

	class Audio extends Playable {
		constructor(title, author, length) {
			super(title, author);
			validateAudioLength(length);
			this._length = length;
		}

		get length() {
			return this._length;
		}

		play() {
			return super.play().concat(` - [${this.length}]`);

		}
	}

	class Video extends Playable {
		constructor(title, author, imdbRating) {
			super(title, author);
			validateImdbRating(imdbRating);
			this._imdbRating = imdbRating;
		}

		get imdbRating() {
			return this._imdbRating;
		}

		play() {
			return super.play().concat(` - [${this.imdbRating}]`);

		}
	}

	const module = {
		getPlayer: function (name) {
			return new Player(name);
		},
		getPlaylist: function (name) {
			return new PlayList(name);
		},
		getAudio: function (title, author, length) {
			return new Audio(title, author, length);
		},
		getVideo: function (title, author, imdbRating) {
			return new Video(title, author, imdbRating);
		}
	};

	return module;
}

module.exports = solve;
