using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSM
    {
        //fields
        private string model = null;
        private string manufacturer = null;
        private decimal? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 190m, "Stamat", new Battery(type: BatteryType.LiPo, hoursTalk: 14, hoursIdle: 200), new Display(16000000, 3.5));

        //constructors
        public GSM(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display) : this(model, manufacturer)
        {
            Price = price;
            Owner = owner;
            Display = display;
            Battery = battery;
        }

        //properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price
        {
            get { return price; }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Price must be greater than 0.");
                }
                else
                {
                    price = value;
                }
            }
        }

        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public static GSM IPhone4S { get { return iPhone4S; } }

        //methods





        public override string ToString()
        {
            return "Mobile phone: " + Manufacturer.ToString() + " " + Model.ToString() +
                "\nPrice: " + (Price != null ? Price.ToString() + " EUR" : "<not specified>") +
                "\nOwner: " + (Owner != null ? Owner.ToString() : "<not specified>") +
                "\nBattery type: " + (Battery != null && Battery.Type != null ? Battery.Type.ToString() : "<not specified>") +
                "\nBattery model: " + (Battery != null && Battery.Model != null ? Battery.Model.ToString() : "<not specified>") +
                "\nTalk time: " + (Battery != null && Battery.HoursTalk != null ? Battery.HoursTalk.ToString() + " hours" : "<not specified>") +
                "\nIdle time: " + (Battery != null && Battery.HoursIdle != null ? Battery.HoursIdle.ToString() + " hours" : "<not specified>") +
                "\nDisplay size: " + (Display != null && Display.Size != null ? Display.Size.ToString() + " inches" : "<not specified>") +
                "\nDisplay colors: " + (Display != null && Display.NumberOfColors != null ? Display.NumberOfColors.ToString() : "<not specified>") +
                "\n***************";
        }
    }
}