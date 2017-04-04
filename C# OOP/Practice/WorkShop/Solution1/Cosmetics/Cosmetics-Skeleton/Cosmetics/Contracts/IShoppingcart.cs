using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;

namespace Cosmetics.Cart
{
    public interface IShoppingCart
    {
         void AddProduct(IProduct productAdd);
         void RemoveProduct(IProduct productRemove);
         bool ContainsProduct(IProduct productName);
         decimal TotalPrice();
    }
}
