using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class CalculateDistance
    {
        public static double DistanceCalculation(Point3DCoord firstPoint, Point3DCoord secondPoint)
        {
            double distX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double distY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            double distZ = Math.Pow((firstPoint.Z - secondPoint.Z), 2);

            double totalDist = Math.Sqrt(distX + distY + distZ);
            return totalDist;

        }
    }
}
