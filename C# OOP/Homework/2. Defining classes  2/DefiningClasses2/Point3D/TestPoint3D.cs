using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class TestPoint3D
    {
        static void Main()
        {

            Path newPath = PathStorage.LoadFile();
            Point3DCoord point = new Point3DCoord(5, 10, 15);

            newPath.InsertPoint(point);

            foreach (var item in newPath.pathToSequence)
            {
                Console.WriteLine(item.ToString());
            }

            PathStorage.SaveFile(newPath);

            Point3DCoord firstPoint = new Point3DCoord(1, 1, 2);
            Point3DCoord secondPoint = new Point3DCoord(2, 1, 1);

            Console.WriteLine(CalculateDistance.DistanceCalculation(firstPoint, secondPoint));
        }
    }
}
