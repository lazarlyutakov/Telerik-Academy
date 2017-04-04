using System;

namespace triangleSurface3sides
{
    class triangleSurface3sides
    {
        static void Main()
        {
            double firstSide = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double secondSide = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double thirdSide = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double semiPerim = (firstSide + secondSide + thirdSide) / 2;
            double surface = Math.Sqrt(semiPerim * (semiPerim - firstSide) * (semiPerim - secondSide) * (semiPerim - thirdSide));

            Console.WriteLine("{0:f2}", surface);
        }
    }
}
