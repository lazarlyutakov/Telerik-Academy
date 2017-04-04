using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
  public class Circle : Figure
    {
        public double Radius { get; set; }

        public override double CalcSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
