using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookTaskN5
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
    }
}
