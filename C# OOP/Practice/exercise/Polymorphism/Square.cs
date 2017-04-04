using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Figure
    {
        public double Size { get; set; }

        public override double CalcSurface()
        {
            return this.Size * this.Size;
        }
    }
}
