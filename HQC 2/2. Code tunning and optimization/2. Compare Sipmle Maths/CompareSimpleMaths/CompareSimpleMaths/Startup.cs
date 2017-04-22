using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int intValue1 = 9;
            int intValue2 = 8;
            long longValue1 = 981235652L;
            long longValue2 = 655225632L;
            float floatValue1 = 2.5f;
            float floatValue2 = 3.7f;
            double doubleValue1 = 1212.78d;
            double doubleValue2 = 6512.48d;
            decimal decimalValue1 = 0.0055624555655m;
            decimal decimalValue2 = 1.545645425m;

            // In order to test all the posible combinations, you can replace the data types 
            // when instantiating the PerformanceComparer class and putting
            // the corresponding parameteres

            // Int vs Long Comparison
            Console.WriteLine("Int vs Long Comparison");
            Console.WriteLine("\r\n" + new string('-', 80) + "\r\n");

            var intLongCompare = new PerformanceComparer<int, long>();
           
            intLongCompare.CompareAddition(intValue1, intValue2, longValue1, longValue2);
            intLongCompare.CompareSubstract(intValue1, intValue2, longValue1, longValue2);
            intLongCompare.CompareMultiplication(intValue1, intValue2, longValue1, longValue2);
            intLongCompare.CompareDividing(intValue1, intValue2, longValue1, longValue2);
            intLongCompare.CompareIncemet(intValue1, longValue1);

            // Float vs Double Comparison
            Console.WriteLine("Float vs Double Comparison");
            Console.WriteLine("\r\n" + new string('-', 80) + "\r\n");

            var floatDoubleCompare = new PerformanceComparer<float, double>();

            floatDoubleCompare.CompareAddition(floatValue1, floatValue2, doubleValue1, doubleValue2);
            floatDoubleCompare.CompareSubstract(floatValue1, floatValue2, doubleValue1, doubleValue2);
            floatDoubleCompare.CompareMultiplication(floatValue1, floatValue2, doubleValue1, doubleValue2);
            floatDoubleCompare.CompareDividing(floatValue1, floatValue2, doubleValue1, doubleValue2);
            floatDoubleCompare.CompareIncemet(floatValue1, doubleValue1);

        }
    }
}
