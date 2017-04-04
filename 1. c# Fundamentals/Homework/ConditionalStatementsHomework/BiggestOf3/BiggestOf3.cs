using System;

class BiggestOf3
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double c = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double maxNum;
        maxNum = Math.Max(a, Math.Max(b, c));

        Console.WriteLine(maxNum);
    }
}

