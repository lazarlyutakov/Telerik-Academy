using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {

        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private static readonly GSM iPhone4S = new GSM("4S", "Apple", 1200, "Pesho", new Battery(100, 10, BatteryType.LiIon),
                                              new Display(4.0f, 1600000));

        public List<Call> callHistory = new List<Call>();
        private const float pricePerMin = 0.37f;


        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public float Price
        {
            get { return price; }

            set
            {
                if (value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException("Please, enter a valid price !");
                }

                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner { get; set; }

        public static GSM Iphone4S { get { return iPhone4S; } }

        public Call CallHistory { get; set; }



        public GSM()
        {
        }

        public GSM(Battery battery)
        {
            this.Battery = battery;
        }

        public GSM(Display display)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, float price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer, float price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, float price, string owner, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, float price, string owner, Battery battery, Display display)
        {

            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

        }



        public void AddCalls(Call data)
        {
            callHistory.Add(data);
        }

        public void DeleteCalls(Call data)
        {
            callHistory.Remove(data);
        }

        public void ClearCalls()
        {
            callHistory.Clear();
        }

        public double CalculatePrice()
        {
            double duratation = 0;

            foreach (var item in callHistory)
            {
                duratation += item.Duratation;
            }

            double price = (duratation / 60) * pricePerMin;
            return price;
        }


        public override string ToString()
        {
            return "Mobile phone: " + Manufacturer + " " +
                "\nModel : " + Model +
                "\nPrice: " + (Price != 0.0f ? Price + " $" : "no input") +
                "\nOwner: " + (Owner != null ? Owner : "no input") +
                "\nHours Talk: " + (Battery != null && Battery.BattHoursTalk != 0 ? Battery.BattHoursTalk + " hrs" : "no input") +
                "\nHours Idle: " + (Battery != null && Battery.BattHoursIdle != 0 ? Battery.BattHoursIdle + " hrs" : "no input") +
                "\nBattery type: " + (Battery != null && Battery.BatteryType != 0 ? Battery.BatteryType.ToString() : "no input") +
                "\nDisplay size: " + (Display != null && Display.Size != 0 ? Display.Size + "\" " : "no input") +
                "\nDisplay Number of Colors: " + (Display != null && Display.NumbOfColors != 0 ? Display.NumbOfColors.ToString() : "no input") +
                "\n";
        }


        static void Main()
        {
            GSM tel = new GSM("One", "HTC", 1200, "Az", new Battery(100, 10, BatteryType.LiIon), new Display(4.0f, 1600000));
            Console.WriteLine(tel);

        }
    }
}