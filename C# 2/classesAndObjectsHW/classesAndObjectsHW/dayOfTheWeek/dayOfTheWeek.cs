using System;
using System.Globalization;


namespace dayOfTheWeek
{
    class dayOfTheWeek
    {
        static void Main()
        {
            DateTime dayOfTheWeek =  DateTime.Today;
            Console.WriteLine("{0:dddd}",dayOfTheWeek);
            Console.WriteLine(dayOfTheWeek.ToString("dddd",new CultureInfo("en-US")));
            Console.WriteLine(DateTime.Today.DayOfWeek);
            Console.WriteLine(DateTime.Today.DayOfYear);
        }
    }
}
