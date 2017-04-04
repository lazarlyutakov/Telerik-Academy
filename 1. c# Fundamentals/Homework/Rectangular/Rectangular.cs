using System;

    class Rectangular
    {
        static void Main()
        {

        float width =(float) Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float height = (float)Convert.ToSingle(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        float area = (float)width * height;
        float perimeter =(float) width * 2.0f + height * 2.0f;

        Console.Out.WriteLine(area.ToString("#.00") + " " + perimeter.ToString("#.00"));
        Console.WriteLine();
        }
    }

