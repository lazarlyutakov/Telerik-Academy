namespace CohesionNCoupling.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;

    internal class CalcAssistant3D
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double Depth { get; set; }

        internal static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        internal static double CalcVolume(IShape3D shape)
        {
            double volume = shape.Width * shape.Height * shape.Depth;
            return volume;
        }

        internal static double CalcDiagonalXYZ(IShape3D shape)
        {
            double distance = CalcDistance3D(0, 0, 0, shape.Width, shape.Height, shape.Depth);
            return distance;
        }
    }
}
