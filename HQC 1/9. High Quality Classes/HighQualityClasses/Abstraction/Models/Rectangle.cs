namespace Abstraction.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Abstraction.Contracts;

    public class Rectangle : Figure, IRectangle
    {
        private const string MustBeGreaterThanZeroErrorMessage = "{0} must be greater than zero!";
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

           private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(MustBeGreaterThanZeroErrorMessage, "Widht"));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(MustBeGreaterThanZeroErrorMessage, "Height"));
                }

                this.height = value;
            }
        }

        protected override double CalculatePerimeter()
        {
            double perimeter =  (2 * this.Width) + (2 * this.Height);
            return perimeter;
        }

        protected override double CalculateSurface()
        {
            double surface =  this.Width * this.Height;
            return surface;
        }
    }
}
