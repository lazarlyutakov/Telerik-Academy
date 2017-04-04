using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException.cs
{
    class Startup
    {
        static void Main(string[] args)
        {
           //  TestNumber();
            Testdate();
        }




        public static void TestNumber()
        {
            Console.Write("Enter a number : ");
            int input = int.Parse(Console.ReadLine());

            try
            {
                if (0 > input || input > 100)
                {
                    throw new InvalidRangeException<int>("Your input is not valid -", 0, 100);

                }
                Console.WriteLine("You entered a number successfully !");
            }
            catch (InvalidRangeException<int> wrong)
            {
                Console.WriteLine("{0} number must be [{1}....{2}].", wrong.Message, wrong.Start, wrong.End);
            }
        }


        public static void Testdate()
        {
            Console.Write("Enter a date in the format dd/mm/yyyy : ");
            DateTime input = DateTime.Parse(Console.ReadLine());

            try
            {
                if (new DateTime(1980, 1, 1) > input || input > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Your input is invalid -", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
                Console.WriteLine("You entered a date successfully !");
            }
            catch (InvalidRangeException<DateTime> invalid)
            {
                Console.WriteLine("{0} date must be [{1}....{2}].", invalid.Message, invalid.Start, invalid.End);
            }

        }
    }
}







