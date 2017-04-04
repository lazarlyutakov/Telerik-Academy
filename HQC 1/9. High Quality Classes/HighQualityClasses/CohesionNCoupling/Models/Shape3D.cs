namespace CohesionNCoupling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CohesionNCoupling.Contracts;

    internal class Shape3D : IShape3D
    {
        private double width;
        private double height;
        private double depth;

        public Shape3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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
                    throw new ArgumentException("Width must be greater than zero!");
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
                    throw new ArgumentException("Height must be greater than zero!");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth must be greater than zero!");
                }

                this.depth = value;
            }
        }
    }
}
