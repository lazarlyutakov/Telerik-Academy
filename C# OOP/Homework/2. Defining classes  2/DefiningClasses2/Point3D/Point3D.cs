namespace Point3D
{
    public struct Point3DCoord
    {

        private double x;
        private double y;
        private double z;

        private static readonly Point3DCoord startCoordSystem = new Point3DCoord(0, 0, 0);

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }



        public Point3DCoord(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3DCoord StartOfCordinateSystem
        {
            get { return startCoordSystem; }
        }

        public override string ToString()
        {
            return string.Format("Point: {0}, {1}, {2}", this.X, this.Y, this.Z);
        }
    }
}
