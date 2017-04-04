using System;

class BiggestOf5
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double c = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double d = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double e = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double maxNum;
        maxNum = Math.Max(a, (Math.Max(b, c)));
        double maxnum1 = Math.Max(maxNum, Math.Max(d, e));

        Console.WriteLine(maxnum1);
    }
}

