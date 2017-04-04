using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Circle
    {
        public static double PI = 3.14;

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static double CalculateSurface (double radius)
        {
            return (PI * radius * radius);
        }

        public void PrintSurface()
        {
            double surface = CalculateSurface(radius);
            Console.WriteLine("Surface is : " + surface);
        }
    }
}
