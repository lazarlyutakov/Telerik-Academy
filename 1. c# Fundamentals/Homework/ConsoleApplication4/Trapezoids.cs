using System;

class Program
{
    static void Main()
    {
        float a = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float b = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float h = Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        float area = ((a + b) / 2.0f) * h;


        Console.WriteLine(area.ToString("0.0000000"));
    }
}
