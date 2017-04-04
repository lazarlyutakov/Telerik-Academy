using System;

    class Circle
    {
        static void Main()
        {
        double r=Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }

