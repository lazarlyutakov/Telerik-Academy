using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double x = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double factoriel = 1;
        double sum = 1+1/x;    

        for (int i = 2; i <= n; i++)
        {
            factoriel *= i;
            sum = sum +  factoriel / Math.Pow(x, i);
        }

        Console.WriteLine("{0:f5}", sum);

    }
}

