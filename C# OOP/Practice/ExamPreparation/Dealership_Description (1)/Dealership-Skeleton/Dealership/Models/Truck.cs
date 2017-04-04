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
    public class Truck : Vehicle, ITruck
    {
        private const string WeightCapacityProp = "Weight Capacity";

        private readonly int weightCapacity;

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
        }

        public Truck(string make, string model, decimal price, int weightCapacity) : base(make, model, price, VehicleType.Truck)
        {
            this.weightCapacity = weightCapacity;

            this.ValidationFields();
        }

        private void ValidationFields()
        {
            Validator.ValidateIntRange(this.weightCapacity, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, WeightCapacityProp, Constants.MinCapacity, Constants.MaxCapacity));
        }

        protected override string PrintAdditionalInfo()
        {
            return string.Format("  Weight Capacity: {0}t", this.WeightCapacity);
        }
    }
}
