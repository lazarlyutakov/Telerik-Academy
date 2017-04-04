using System;

class abc2016Feb3rdEvening
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        double maxNum = Math.Max(a, (Math.Max(b, c)));
        double minNum = Math.Min(a, Math.Min(b, c));

        double mean = (a + b + c) / 3;

        Console.WriteLine(maxNum);
        Console.WriteLine(minNum);
        Console.WriteLine("{0:f3}", mean);



    }
}

