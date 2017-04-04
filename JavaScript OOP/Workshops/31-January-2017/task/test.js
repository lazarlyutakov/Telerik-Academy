'use strict';



function solve() {
	function getProduct(productType, name, price) {
		return {
	  productType : productType,
	  name : name,
	  price : price
		};
	}

	function getShoppingCart() {
		let products = [];
         function Result (products){
                let answer = 0;
            	for(let i = 0; i < products.length ; i += 1) {
				   answer += products[i].price;				
				}
             return answer;
        };

		return{
			products,
			add : function(){},			
			remove : function(){},
			showCost : function(){
				let result = 0;			
				if(products.length === 0){
					return 0;
				}
			
                   return Result(products);
			},

			showProductTypes : function(){
				let output = [];
					if(products.length === 0){
					return '';
				}
				for(let i = 0; i < products.length ; i += 1) {
					output.push(products[i].productType);
				}

			     var unique = output.filter(function(elem, index, self) {
                   return index == self.indexOf(elem);
                  });
				  return unique;
			},


			getInfo : function(){
				if(products.length === 0){
					let resultArray = [];
					return{
						totalPrice : 0,
						products : []
					};
				}
			}

		};
	}

	return {
		getProduct: getProduct,
		getShoppingCart: getShoppingCart
	};
}

module.exports = solve();























// 'use strict';



// function solve() {
// 	function getProduct(productType, name, price) {
// 		return {
// 	  productType : productType,
// 	  name : name,
// 	  price : price
// 		};
// 	}

// 	function getShoppingCart() {
// 		let products = [];
// 		return{
// 			products,
// 			add : function(){},			
// 			remove : function(){},
// 			showCost : function(){
// 				let result = 0;			
// 				if(products.length === 0){
// 					return 0;
// 				}
// 				for(let i = 0; i < products.length ; i += 1) {
// 				   result += products[i].price;				
// 				}
// 				   return result;
// 			},

// 			showProductTypes : function(){
// 				let output = [];
// 					if(products.length === 0){
// 					return '';
// 				}
// 				for(let i = 0; i < products.length ; i += 1) {
// 					output.push(products[i].productType);
// 				}

// 			     var unique = output.filter(function(elem, index, self) {
//                    return index == self.indexOf(elem);
//                   });
// 				  return unique;
// 			},


// 			getInfo : function(){
// 				if(products.length === 0){
// 					let resultArray = [];
// 					return{
// 						totalPrice : 0,
// 						products : []
// 					};
// 				}
// 			}

// 		};
// 	}

// 	return {
// 		getProduct: getProduct,
// 		getShoppingCart: getShoppingCart
// 	};
// }

// module.exports = solve();