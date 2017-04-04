using System;


namespace triangleSurfaceAngle
{
    class triangleSurfaceAngle
    {
        static void Main()
        {
            double firstSide = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double secondSide = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double angle = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double surface = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;

            Console.WriteLine("{0:f2}", surface);

        }
    }
}
