using Cosmetics.Products;

namespace Cosmetics.Engine
{
    using System.Collections.Generic;
 ;


    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using Cart;
	
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            Category currentCategory = new Category();
            currentCategory.Name = name;
            return currentCategory;
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            Shampoo currentShampoo = new Shampoo();
            currentShampoo.Name = name;
            currentShampoo.Brand = brand;
            currentShampoo.Price = price;
            currentShampoo.Gender = gender;
            currentShampoo.Milliliters = milliliters;
            currentShampoo.Usage = usage;
            return currentShampoo;
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            Toothpaste currentToothpaste = new Toothpaste();
            currentToothpaste.Name = name;
            currentToothpaste.Brand = brand;
            currentToothpaste.Price = price;
            currentToothpaste.Gender = gender;
            string currentIngredients = string.Empty;

            for (int i = 0; i < ingredients.Count; i++)
            {
                if (i == ingredients.Count - 1)
                {
                    currentIngredients += ingredients[i];
                }
                else
                {
                    currentIngredients += ingredients[i] + ", ";
                }
            }
            currentToothpaste.Ingredients = currentIngredients;
            return currentToothpaste;
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
