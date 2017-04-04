using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste, IProduct
    {


        private string ingredients;
        public string Ingredients
        {
            get { return this.ingredients; }
            set { this.ingredients = value; }
        }

        private string PrintIngredients(string ingredients)
        {
            string stFinal = string.Empty;
            string[] currentIngredients = ingredients.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < currentIngredients.Length; i++)
            {
                if (i == currentIngredients.Length - 1)
                {
                    stFinal += currentIngredients[i];
                }
                else
                {
                    stFinal += currentIngredients[i] + ", ";
                }
            }
            return stFinal;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", this.Price));
            sb.AppendLine(string.Format("  * For gender: {0}", CheckGenderType(this.Gender)));
            sb.AppendLine(string.Format("  * Ingredients: {0}", PrintIngredients(this.Ingredients)));
            return sb.ToString().Trim();
        }
    }
}
