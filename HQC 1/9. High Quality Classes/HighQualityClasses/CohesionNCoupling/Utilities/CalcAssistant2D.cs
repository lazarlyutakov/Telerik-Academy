namespace CohesionNCoupling.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CohesionNCoupling.Contracts;

    internal static class CalcAssistant2D
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        internal static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        internal static double CalcDiagonalXY(IShape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Height);
            return distance;
        }

        internal static double CalcDiagonalXZ(IShape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Depth);
            return distance;
        }

        internal static double CalcDiagonalYZ(IShape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Height, shape.Depth);
            return distance;
        }
    }
}
