using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Startup
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Rectangle(3, 5.5),
                new Square(4),
                new Triangle (2, 7),
                new Rectangle(8, 2),
                new Square(9),
                new Triangle(4, 3)
            };

            foreach (Shape item in shapes)
            {
                Console.WriteLine("Shape : {0} surface = {1:f1}", item.GetType().Name, item.CalculateSurface());
            }

    





        }
    }
}
