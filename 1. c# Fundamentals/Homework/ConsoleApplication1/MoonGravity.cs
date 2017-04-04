using System;

    class Program
    {
        static void Main()
        {
        float W = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float MoonW = W * 0.17f;
        

        Console.Out.WriteLine(MoonW.ToString("0.000"));
        }  
    }

