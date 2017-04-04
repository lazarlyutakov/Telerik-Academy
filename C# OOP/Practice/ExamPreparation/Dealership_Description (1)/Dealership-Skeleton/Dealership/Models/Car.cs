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
   public class Car : Vehicle, ICar
    {
        private const string SeatsProperty = "Seats";

        private readonly int seats;

        public int Seats
        {
            get
            {
                return this.seats;
            }
        }

        public Car(string make, string model, decimal price, int seats) : base(make, model, price, VehicleType.Car)
        {
            this.seats = seats;

            this.ValidateFields();
        }


        protected override string PrintAdditionalInfo()
        {
            return string.Format("  {0}: {1}", SeatsProperty, this.Seats);
        }

        private void ValidateFields()
        {
            Validator.ValidateIntRange(this.seats, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, SeatsProperty, Constants.MinSeats, Constants.MaxSeats));
        }
    }
}
