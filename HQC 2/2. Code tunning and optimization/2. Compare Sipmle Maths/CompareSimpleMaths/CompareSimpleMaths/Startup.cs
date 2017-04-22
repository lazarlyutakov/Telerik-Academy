using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    class Startup
    {
        static void Main(string[] args)
        {
            var intArray = new int[10];
            var longArray = new long[10];
            var floatArray = new float[10];
            var doubleArray = new double[10];
            var decimalArray = new decimal[10];

            var intLongCompare = new PerformanceComparer<int, long>();

            // Int vs Long Comparison
            intLongCompare.CompareAddition(intArray, longArray);

        }
    }
}
