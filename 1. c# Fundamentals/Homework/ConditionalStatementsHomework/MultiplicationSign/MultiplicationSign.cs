using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double c = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        if ((a * b * c) > 0)
        {
            Console.WriteLine("+");
        }
        else if ((a * b * c) < 0)
        {
            Console.WriteLine("-");
        }
        else if ((a * b * c) == 0)
        {
            Console.WriteLine(0);
        }
    }
}

