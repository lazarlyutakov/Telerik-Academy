using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Products;
using Cosmetics.Contracts;
using Cosmetics.Engine;
using Cosmetics.Common;

namespace Cosmetics
{
    class Category : ICategory
    {
        private string name;
        private const int minLength = 2;
        private const int maxLength = 15;
        private List<IProduct> productList;

        public Category()
        {
            
            this.productList = new List<IProduct>();
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < minLength || value.Length > maxLength)
                {
                    throw new Exception(string.Format("Category name must be between {0} and {1} symbols long!", minLength, maxLength));
                }
                else
                {
                    this.name = value;
                }
            }
        }


        public void AddCosmetics(IProduct productToAdd)
        {
            productList.Add(productToAdd);
        }

        public void RemoveCosmetics(IProduct productToRemove)
        {
            bool result = productList.Remove(productToRemove);
            if (result == false)
            {
                throw new Exception(string.Format("Product {0} does not exist in category {1}!", productToRemove.Name, this.Name));
            }
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0} category - {1} in total", this.Name, productList.Count == 1 ? productList.Count + " product" : productList.Count + " products").Trim());
            foreach (var product in productList.OrderBy(el => el.Brand).ThenByDescending(el => el.Price).ToList())
            {
                result.AppendLine(product.ToString().Trim());
            }
            return result.ToString().Trim();
        }

    }
}
