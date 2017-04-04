using System;

    class ExchangingNumbers
    {
        static void Main()
        {
        double a = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        if(a>b)
        {
            Console.WriteLine("{0} {1}",b,a);
        }
        else
        {
            Console.WriteLine("{0} {1}",a,b);
        }
    }
    }

