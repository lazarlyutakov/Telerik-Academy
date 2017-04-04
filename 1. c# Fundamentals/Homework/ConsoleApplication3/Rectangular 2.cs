using System;
    class Program
    {
        static void Main()
        {
        double width = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        double area = width * height;
        double perimeter = width * 2.0f + height * 2.0f;

        Console.Out.WriteLine(area.ToString("#.00") + " " + perimeter.ToString("#.00"));
        Console.WriteLine();

        }
    }

