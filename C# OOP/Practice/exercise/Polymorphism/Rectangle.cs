using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalcSurface()
        {
            return this.Width * this.Height;
        }
    }
}
