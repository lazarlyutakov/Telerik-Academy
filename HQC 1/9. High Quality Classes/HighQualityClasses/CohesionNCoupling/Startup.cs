namespace CohesionNCoupling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Utilities;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FileNameUtils.GetFileExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("==============================================================");

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalcAssistant2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalcAssistant3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("==============================================================");

            var shape = new Shape3D(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", CalcAssistant3D.CalcVolume(shape));
            Console.WriteLine("Diagonal XYZ = {0:f2}", CalcAssistant3D.CalcDiagonalXYZ(shape));
            Console.WriteLine("Diagonal XY = {0:f2}", CalcAssistant2D.CalcDiagonalXY(shape));
            Console.WriteLine("Diagonal XZ = {0:f2}", CalcAssistant2D.CalcDiagonalXZ(shape));
            Console.WriteLine("Diagonal YZ = {0:f2}", CalcAssistant2D.CalcDiagonalYZ(shape));
        }
    }
}
