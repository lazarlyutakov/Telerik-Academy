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


			add : function(Product){
				products.push(Product);
				return products;
			},		


			remove : function(product){
					const indexOfProduct = this.products.findIndex(pr => pr.name === product.name && 
					                                                    pr.cost === product.cost && 
																		pr.productType === product.productType);	

					if(indexOfProduct === -1){
						throw new Error('Item missing');
					}		
			return products.splice(indexOfProduct, 1);
			},


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

			   let uniqueArray = output.filter(function(item, pos) {
                   return output.indexOf(item) == pos;
              });
			  return uniqueArray.sort();
			},


			getInfo : function(){

			let allProducts = {};
		         this.products.forEach(pr => {
                if (!allProducts[pr.name]) {
                    allProducts[pr.name] = {
                        "name": pr.name,
                        "totalPrice": 0,
                        "quantity": 0
                    };
                }

                allProducts[pr.name].totalPrice += pr.price;
                allProducts[pr.name].quantity += 1;
            });

			let products = Object.keys(allProducts)
			    .sort((k1, k2) => k1.localeCompare(k2))
				.map(key => allProducts[key]);

			let totalPrice = products.reduce((tp,pr) => tp + pr.totalPrice, 0);
			return{
				products,
				totalPrice
			};
			
			}
		};
	}

	return {
		getProduct: getProduct,
		getShoppingCart: getShoppingCart
	};
}

module.exports = solve();
