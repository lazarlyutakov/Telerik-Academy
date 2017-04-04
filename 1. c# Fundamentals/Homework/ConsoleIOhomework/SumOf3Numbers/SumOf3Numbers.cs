using System;

    class SumOf3Numbers
    {
        static void Main()
        {

        float a = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float b = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float c = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        float d = a + b + c;
        Console.WriteLine(d);
        }
    }

