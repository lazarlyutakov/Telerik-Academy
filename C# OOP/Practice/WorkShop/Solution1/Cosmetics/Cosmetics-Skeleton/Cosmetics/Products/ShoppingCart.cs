using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Products;


namespace Cosmetics.Cart
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> shoppingCart;

        public ShoppingCart()
        {
            this.shoppingCart = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            this.shoppingCart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.shoppingCart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            var result = this.shoppingCart.Contains(product);
            return result;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                totalPrice += shoppingCart[i].Price;
            }
            return totalPrice;
        }
    }
}
