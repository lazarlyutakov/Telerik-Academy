using System;


namespace leapYear
{

    class leapYear
    {
        static void Main()
        {

            int inputYear = int.Parse(Console.ReadLine());

            bool isLeap = true;

            if (DateTime.IsLeapYear(inputYear) == isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }

        }
    }
}
