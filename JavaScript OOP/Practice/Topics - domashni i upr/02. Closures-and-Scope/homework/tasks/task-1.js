/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks() {
			if(books.length === 0){			
			return books;
			}

			if(arguments[0]){
				if(arguments[0].hasOwnProperty('category')){
					return books.filter(x => x.category === arguments[0].category);
				}
				if(arguments[0].hasOwnProperty('author')){
					return books.filter(x => x.author === arguments[0].author);
				}
			}

			if(!arguments[0]){
				return books;
			}
			return books;
		}


		function addBook(book) {
            for(let i = 0; i < books.length ; i += 1) {
				if(book.title === books[i].title){
					throw 'Title already in the list !';
				}

				if(book.isbn === books[i].isbn){
					throw 'ISBN already in the list !';
				}
			}

			if(!categories.some(x => x === book.category)){
				categories.push(book.category);
			}

			if(book.title.length < 2 || book.title.length > 100){
				throw 'Enter a valid title !';
			}

			if(book.category.length < 2 || book.category.length > 100){
				throw 'Enter a valid category name !';
			}

			if(typeof book.author !== 'string' || book.author.length < 1){
				throw 'Enter a valid author name !';
			}

			if(!book.isbn.match(/^[0-9]{10}$/) && !book.isbn.match(/^[0-9]{13}$/)){
				throw 'Enter a valid ISBN !';
			}

			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
