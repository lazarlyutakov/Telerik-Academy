using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            DaysOfWeek day = DaysOfWeek.Tuesday;
            Console.WriteLine(day);
            string text = day.ToString();
            text.Split();

            Console.WriteLine((int)day);

            day = DaysOfWeek.Monday;
            Console.WriteLine(++day);
            Console.WriteLine(--day);

            day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Thursday");
            Console.WriteLine(day);
        }
    }


    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday





    }



}




//return "Mobile phone: " + Manufacturer + " " +
//              "\nModel : " + Model +
//              "\nPrice: " + (Price != 0.0f ? Price.ToString() + " $" : "no input") +
//              "\nOwner: " + (Owner != null ? Owner : "no input") +
//              "\nBattery type: " + (Battery != null && Battery.BatteryType != 0 ? Battery.BatteryType.ToString() : "no input") +
//              "\nBattery model: " + (Battery != null && Battery.Model != null ? Battery.Model.ToString() : "no input") +
//              "\nHours Talk: " + (Battery != null && Battery.BattHoursTalk != 0 ? Battery.BattHoursTalk.ToString() + " hours" : "no input") +
//              "\nHours Idle: " + (Battery != null && Battery.BattHoursIdle != 0 ? Battery.BattHoursIdle + " hours" : "no input") +
//              "\nDisplay size: " + (Display != null && Display.Size != 0 ? Display.Size.ToString() + " inches" : "no input") +
//              "\nDisplay Number of Colors: " + (Display != null && Display.NumbOfColors != 0 ? Display.NumbOfColors.ToString() : "no input") +
//              "\n";





