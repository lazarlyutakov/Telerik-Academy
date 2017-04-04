using System;

namespace triangleSurfaceSizeAlt
{
    class triangleSurfaceSizeAlt
    {
        static void Main()
        {
            double size = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double altitude = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double surface = (size * altitude) / 2;

            Console.WriteLine("{0:f2}", surface);
        }
    }
}
