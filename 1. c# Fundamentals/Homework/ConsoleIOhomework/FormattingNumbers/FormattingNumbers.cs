using System;

    class FormattingNumbers
    {
        static void Main()
        {
        int a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double c = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

       
        Console.WriteLine("{0,-10} | {1,10:F10} | {2,10:F2} | {3,-10:F3} |", String.Format("{0:X}", a), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        
        }
    }

