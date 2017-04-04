using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class Square : Shape
    {
        private double size;

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size could be only greater than 0 !");
                }
                this.size = value;
            }
        }

        public Square(double size)
        {
            this.width = size;
            this.heigth = size;
            this.Size = size;
        }

        public override double CalculateSurface()
        {
            return this.Size * this.Size;
        }

    }
}
