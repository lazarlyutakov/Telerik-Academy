using System;

    class NumberComparer
    {
        static void Main()
        {
        double a = Convert.ToDouble(Console.ReadLine(),System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(),System.Globalization.CultureInfo.InvariantCulture);

            if(a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }

