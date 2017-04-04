
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
        this.playerContainer = [];
    }

    get name() {
        return this._name;
    }
    set name(name) {
        isLengthValid(name);
        this._name = name;
    }

    get playerContainer() {
        return this._playerContainer;
    }
    set playerContainer(x) {
        this._playerContainer = x;
    }

    addPlaylist(playlistToAdd) {
        if (playlistToAdd instanceof PlayList) {
            this.playerContainer.push(playlistToAdd);
        }
        else {
            throw Error('Invalid input');
        }
        return this;
    }

    getPlaylistById(id) {
        const result = this.playerContainer.find(i => i.id === id);
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
        if (page * size >= this.playerContainer.length) {
            throw new Error('Not valid');
        }
        if (typeof page !== 'number' || typeof size !== 'number' || page < 0 || size <= 0) {
            throw new Error('Page must be positive integer ; size must be non negative number');
        }


        return this.playerContainer.sort((x, y) => x.name.localeCompare(y.name))
            .sort((x, y) => x.id - y.id);
    }

    contains(playable, playlist) {
        for (let element of this.playerContainer) {
            for (let el of element) {
                if (el instanceof Playable) {
                    return true;
                }
                return false;
            }
        }
    }

    search(pattern) {
        return this.playerContainer.map(x => x.playListContainer)
                            .map(c => c.playable)
                            .sort((x, y) => x.title.localeCompare(y.title));
        
     
    }

}


class PlayList {
    constructor(name) {
        this.name = name;
        this._id = getNextId();
        this.playListContainer = []
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

    get playListContainer() {
        return this._playListContainer;
    }
    set playListContainer(playListContainer) {
        this._playListContainer = playListContainer;
    }

    addPlayable(playable) {
        this.playListContainer.push(playable);

        return this;
    }

    getPlayableById(id) {
        const result = this.playListContainer.find(i => i.id === id);
        if (typeof result === 'undefined') {
            return null;
        }
        return result;
    }

    removePlayable(id) {
        const index = this.playListContainer.findIndex(i => i.id === id);
        if (index === -1) {
            throw Error('Not existing!');
        }
        this.playListContainer.splice(index, 1);

        return this;

    }

    removePlayableByPlayable(playable) {

    }

    listPlayables(page, size) {
        if (page * size >= this.playListContainer.length) {
            throw new Error('Not valid');
        }
        if (typeof page !== 'number' || typeof size !== 'number' || page < 0 || size <= 0) {
            throw new Error('Page must be positive integer ; size must be non negative number');
        }


        return this.playListContainer.sort((x, y) => x.title.localeCompare(y.title))
            .sort((x, y) => x.id - y.id);

    }

}

class Playable {
    constructor(title, author) {
        this._id = getNextIdPlayable();
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
        //[id]. [title] - [author]
        return `[${this.id}]. [${this.title}] - [${this.author}]`;
    }
}

class Audio extends Playable {
    constructor(title, author, length) {
        super(title, author);
        //this._id = getNextId();
        this.length = length;
    }

    // get id() {
    // 	return this._id;
    // }

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
        return super.play().concat(` - [${this.length}]`);
        //return `[${this.id}]. [${this.title}] - [${this.author}] - [${this.length}]`;
    }
}

class Video extends Playable {
    constructor(title, author, imdbRating) {
        super(title, author);
        //this._id = getNextId();
        this.imdbRating = imdbRating;
    }

    // get id() {
    // 	return this._id;
    // }

    get imdbRating() {
        return this._imdbRating;
    }
    set imdbRating(imdbRating) {
        if (typeof imdbRating !== 'number' || imdbRating < 1 || imdbRating > 5) {
            throw Error('Imdb Rating is in invalid format!');
        }
        this._imdbRating = imdbRating;
    }

    play() {
        return super.play().concat(` - [${this.imdbRating}]`);
    }
}

let list = new PlayList('playlist');
let list2 = new PlayList('playlist 2');

let playable = new Playable('title', 'avtor');
let playable1 = new Playable('atitle1', 'avtor1');


let kk = list.addPlayable(playable);

console.log(kk);

