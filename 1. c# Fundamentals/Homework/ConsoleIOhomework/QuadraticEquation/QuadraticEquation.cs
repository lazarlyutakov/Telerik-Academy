using System;

    class QuadraticEquation
    {
        static void Main()
        {

        double a = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double c = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double result = (-b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
        double result1 = (-b - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);

        if ((b * b - 4 * a * c) >= 0 && result < result1)
        {
            Console.WriteLine("{0:F2}\n{1:F2}", result, result1);
            
        }
        else if ((b * b - 4 * a * c) >= 0 && result > result1)
        {
            Console.WriteLine("{0:F2}\n{1:F2}", result1, result);
            
        }
        else if (result == result1 && (b * b - 4 * a * c) >= 0)
        {
            Console.WriteLine("{0:F2}", result);
                           
        }
        else
        {
            Console.WriteLine("no real roots");
        }
        
        }
    }

