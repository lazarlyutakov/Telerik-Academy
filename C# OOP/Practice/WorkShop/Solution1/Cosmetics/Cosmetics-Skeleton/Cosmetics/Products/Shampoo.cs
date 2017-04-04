using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private Common.UsageType usage;
        public uint Milliliters
        {
            get { return this.milliliters; }
            set { this.milliliters = value; }
        }

        public Common.UsageType Usage
        {
            get { return this.usage; }
            set { this.usage = value; }
        }

        public decimal Price
        {
            get { return base.Price * this.Milliliters; }
            set { base.Price = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", this.Price));
            sb.AppendLine(string.Format("  * For gender: {0}", CheckGenderType(this.Gender)));
            sb.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            sb.AppendLine(string.Format("  * Usage: EveryDay", this.Usage));
            return sb.ToString().Trim();
        }
    }
}
