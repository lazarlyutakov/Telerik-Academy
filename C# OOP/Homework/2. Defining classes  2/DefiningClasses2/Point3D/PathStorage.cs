using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point3D
{
    public static class PathStorage
    {
        private static readonly StreamReader loadFile = new StreamReader(@"..\..\file1.txt");
        private static readonly StreamWriter saveFile = new StreamWriter(@"..\..\file2.txt");

        public static Path LoadFile()
        {
            Path pathInUse = new Path();

            using (loadFile)
            {
                string row = loadFile.ReadLine();

                while(row != null)
                {

                    string[] coords = row.Split();

                    Point3DCoord currentPoint = new Point3DCoord()
                    {
                        X = double.Parse(coords[0]),
                        Y = double.Parse(coords[1]),
                        Z = double.Parse(coords[2]),
                    };

                    pathInUse.InsertPoint(currentPoint);
                    row = loadFile.ReadLine();
                }
            }
            return pathInUse;
        }

        public static void SaveFile(Path pathInUse)
        {
            using (saveFile)
            {
                foreach (var character in pathInUse.pathToSequence)
                {
                    string itemToSave = string.Format("{0} {1} {2}", character.X, character.Y, character.Z);
                    saveFile.WriteLine(itemToSave);
                }
            }
        }


    }
}

