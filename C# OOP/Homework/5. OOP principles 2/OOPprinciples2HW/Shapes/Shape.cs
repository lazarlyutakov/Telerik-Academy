using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

   
    public abstract class Shape
    {
        protected double width;
        protected double heigth;

        public abstract double CalculateSurface();
    }
}
