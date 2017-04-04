using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int MinimumNameLength = 3;
        private const int MaximumNameLength = 10;
        private const int MinimumBrandNameLength = 2;
        private const int MaximumBrandNameLength = 10;
        private string name;
        private string brand;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < MinimumNameLength || value.Length > MaximumNameLength)
                {
                    throw new Exception(string.Format("Product name must be between {0} and {1} symbols long!", MinimumNameLength, MaximumNameLength));
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Brand
        {
            get { return this.brand; }
            set
            {
                if (value.Length < MinimumBrandNameLength || value.Length > MaximumBrandNameLength)
                {
                    throw new Exception(string.Format("Product brand must be between {0} and {1} symbols long!", MinimumBrandNameLength, MaximumBrandNameLength));
                }
                else
                {
                    this.brand = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Common.GenderType Gender { get; set; }

        public string Print()
        {
            return string.Format("Name: {0}, Brand: {1}", this.Name, this.Brand);
        }
        protected string CheckGenderType(GenderType gt)
        {
            return gt.ToString();
        }
    }
}
