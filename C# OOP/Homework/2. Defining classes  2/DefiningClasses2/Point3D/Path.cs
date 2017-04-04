using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        public List<Point3DCoord> pathToSequence = new List<Point3DCoord>();


        public void InsertPoint(Point3DCoord newPoint)
        {
            pathToSequence.Add(newPoint);
        }

        public void RemovePoint(Point3DCoord pointToRemove)
        {
            pathToSequence.Remove(pointToRemove);
        }
    }
}
