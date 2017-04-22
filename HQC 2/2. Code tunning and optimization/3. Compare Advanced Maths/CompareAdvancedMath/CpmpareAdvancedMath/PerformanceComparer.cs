using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmpareAdvancedMath
{
    internal class PerformanceComparer<T, K>
    {
        public void CompareSquareRoot(T tValue1, K kValue1)
        {
            dynamic firstTypeNumb = tValue1;
            dynamic secondTypeNumb = kValue1;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = Math.Sqrt(firstTypeNumb);

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the square root of the first type value --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = Math.Sqrt((double)secondTypeNumb);

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the square root of the second type value --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareNaturalLogarithm(T tValue1, K kValue1)
        {
            dynamic firstTypeNumb = tValue1;
            dynamic secondTypeNumb = kValue1;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = Math.Log(firstTypeNumb);

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the natural logarithm of the first type value --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = Math.Log((double)secondTypeNumb);

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the natural logarithm of the second type value --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareSinus(T tValue1, K kValue1)
        {
            dynamic firstTypeNumb = tValue1;
            dynamic secondTypeNumb = kValue1;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = Math.Sin(firstTypeNumb);

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the sinus of the first type value --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = Math.Sin((double)secondTypeNumb);

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for calculating the sinus of the second type value --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }
    }
}
