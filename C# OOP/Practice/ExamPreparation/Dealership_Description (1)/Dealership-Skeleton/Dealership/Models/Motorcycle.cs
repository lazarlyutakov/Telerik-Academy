using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
   public class Motorcycle : Vehicle, IMotorcycle
    {
        private const string CategoryProp = "Category";

        private readonly string category;

        public string Category
        {
            get
            {
                return this.category;
            }
        }

        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price, VehicleType.Motorcycle)
        {
            this.category = category;

            this.ValidateFields();
        }


        protected override string PrintAdditionalInfo()
        {
            return string.Format("  {0}: {1}", CategoryProp, this.Category);
        }


        private void ValidateFields()
        {
            Validator.ValidateIntRange(this.category.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, CategoryProp, Constants.MinCategoryLength, Constants.MaxCategoryLength));
        }
    }
}
