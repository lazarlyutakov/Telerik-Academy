using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookTaskN5
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}
