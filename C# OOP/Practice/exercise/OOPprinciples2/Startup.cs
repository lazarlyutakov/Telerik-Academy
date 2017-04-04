using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples2
{
    class Startup
    {
        static void Main(string[] args)
        {
            Figure[] figures =
            {
                new Line(),
                new Circle(),
                new SpecialFigure(),
                new Line()
            };

            foreach (var f in figures)
            {
                f.Draw();
                Console.WriteLine();
            }
        }
    }
}
