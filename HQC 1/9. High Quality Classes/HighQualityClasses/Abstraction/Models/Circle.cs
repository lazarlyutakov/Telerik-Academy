namespace Abstraction.Models
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Abstraction.Contracts;

    public class Circle : Figure, ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than zero!");
                }

                this.radius = value;
            }
        }

        protected override double CalculatePerimeter()
        {
            double perimeter = Math.PI * this.Radius * 2;
            return perimeter;
        }

        protected override double CalculateSurface()
        {
            double surface =  Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
