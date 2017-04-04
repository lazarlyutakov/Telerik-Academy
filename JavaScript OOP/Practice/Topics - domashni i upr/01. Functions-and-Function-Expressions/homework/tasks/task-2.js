/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/


function solve() {
	return function findPrimes(x, y){
		x = +x;
		y = +y;
		let array = [];
		
		if(isNaN(x) || isNaN(y)){
			throw 'Error';
		}

		for(let i = x; i <= y  ; i += 1) {
			if(primeNumbs(i)){
				array.push(i);
			}
		}
		return array;
	
	function primeNumbs(number){
		let divider = Math.floor(Math.sqrt(number));

		if(number < 2){
			return false;
		}

		for(let i = 2; i <= divider ; i += 1) {
			if(number % i === 0){
				return false;
			}
		}
		return true;
	}
  };
}


module.exports = solve;
