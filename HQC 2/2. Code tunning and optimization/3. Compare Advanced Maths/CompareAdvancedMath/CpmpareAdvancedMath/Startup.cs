using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmpareAdvancedMath
{
    class Startup
    {
        static void Main(string[] args)
        {
            float floatValue = 2.7f;
            double doubleValue = 487555.655d;
            decimal decimalValue = 0.2415121554512555m;

            // Float vs Double
            var floatVsDoubleComparer = new PerformanceComparer<float, double>();

            Console.WriteLine("Compare float vs double :");
            Console.WriteLine("\r\n" + new string('-', 80) + "\r\n");

            floatVsDoubleComparer.CompareSquareRoot(floatValue, doubleValue);
            floatVsDoubleComparer.CompareNaturalLogarithm(floatValue, doubleValue);
            floatVsDoubleComparer.CompareSinus(floatValue, doubleValue);

            //Float vs Decimal
           var floatVsDecimalComparer = new PerformanceComparer<float, decimal>();

            Console.WriteLine("Compare float vs decimal :");
            Console.WriteLine("\r\n" + new string('-', 80) + "\r\n");

            floatVsDecimalComparer.CompareSquareRoot(floatValue, decimalValue);
            floatVsDecimalComparer.CompareNaturalLogarithm(floatValue, decimalValue);
            floatVsDecimalComparer.CompareSinus(floatValue, decimalValue);
            
            //Double vs Decimal
           var doubleVsDecimalComparer = new PerformanceComparer<double, decimal>();

            Console.WriteLine("Compare double vs decimal :");
            Console.WriteLine("\r\n" + new string('-', 80) + "\r\n");

            doubleVsDecimalComparer.CompareSquareRoot(doubleValue, decimalValue);
            doubleVsDecimalComparer.CompareNaturalLogarithm(doubleValue, decimalValue);
            doubleVsDecimalComparer.CompareSinus(doubleValue, decimalValue);

        }
    }
}
