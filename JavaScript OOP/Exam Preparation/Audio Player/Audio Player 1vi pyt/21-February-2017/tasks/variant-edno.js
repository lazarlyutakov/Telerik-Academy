function solve() {
	const getNextId = (function () {
        let counter = 0;
        return function () {
            counter += 1;
            return counter;
        };
    })();

    let playerDataManager = {
        playerContainer: []
    };

    const isLengthValid = function (input) {
        if (typeof input !== 'string' || input.length < 3 || input.length > 25) {
            throw Error('Invalid input');
        }
    };

    class Player {
        constructor(name) {
            this.name = name;
        }

        get name() {
            return this._name;
        }
        set name(name) {
            isLengthValid(name);
            this._name = name;
        }

        addPlaylist(playlistToAdd) {
            if (playlistToAdd instanceof PlayList) {
                playerDataManager.playerContainer.push(playlistToAdd);
            }
            else {
                throw Error('Invalid input');
            }
            return this;
        }

        getPlaylistById(id) {
            const result = playerDataManager.playerContainer.find(i => i.id === id);
            if (typeof result === 'undefined') {
                return null;
            }
        }


        removePlaylist(id) {
            const index = this.playerContainer.findIndex(i => i.id === id);
            if (index === -1) {
                throw Error('Not existing!');
            }
            this.playerContainer.splice(index, 1);

            return this;
        }

        removePlaylistByPlayList(playlist) {
            const index = this.playerContainer.findIndex(i => i.id === playlist.id);
            if (index === -1) {
                throw Error('Not existing!');
            }
            this.playerContainer.splice(index, 1);

            return this;
        }

        listPlaylists(page, size) {
			

        }

        contains(playable, playlist) {

        }

        search(pattern) {

        }

    }


    class PlayList {
        constructor(name) {
            this.name = name;
            this._id = getNextId();
        }

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }
        set name(name) {
            isLengthValid(name);
            this._name = name;
        }

        addPlayable(playable) {

        }

        getPlayableById(id) {

        }

        removePlayable(id) {

        }

        removePlayableByPlayable(playable) {

        }

        listPlayables(page, size) {

        }

    }

    class Playable {
        constructor(title, author) {
            this._id = getNextId();
            this.title = title;
            this.author = author;
        }

        get id() {
            return this._id;
        }

        get title() {
            return this._title;
        }
        set title(title) {
            isLengthValid(title);
            this._title = title;
        }

        get author() {
            return this._author;
        }
        set author(author) {
            isLengthValid(author);
            this._author = author;
        }

        play() {

        }
    }

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);
            this._id = getNextId();
            this.length = length;
        }

        get id() {
            return this._id;
        }

        get length() {
            return this._length;
        }
        set length(length) {
            if (typeof length !== 'number' || length < 0) {
                throw Error('Invalid length!');
            }
            this._length = length;
        }

        play() {
            //check how to reuse
        }
    }

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);
            this._id = getNextId();
            this.imdbRating = imdbRating;
        }

        get id() {
            return this._id;
        }

        get imdbRating() {
            return this._imdbRating;
        }
        set imdbRating(imdbRating) {
            if (typeof imdbRating !== 'numbner' || imdbRating < 1 || imdbRating > 5) {
                throw Error('Imdb Rating is in invalid format!');
            }
            this._imdbRating = imdbRating;
        }

        play() {
            //check how to reause 
        }
    }


	const module = {
		getPlayer: function (name){
			return new Player(name);
		},
		getPlaylist: function(name){
			return new PlayList(name);
		},
		getAudio: function(title, author, length){
			return new Audio(title, author, length);
		},
		getVideo: function(title, author, imdbRating){
			return new Video(title, author, imdbRating);
		}
	};

	return module;
}

module.exports = solve;
