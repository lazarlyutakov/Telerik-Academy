using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width could be only greater than 0 !");
                }
                this.width = value;
            }
        }


        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Heigth could be only greater than 0 !");
                }
                this.heigth = value;
            }
        }

        public Triangle(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public override double CalculateSurface()
        {
            return (this.width * this.heigth) / 2;
        }
    }
}
