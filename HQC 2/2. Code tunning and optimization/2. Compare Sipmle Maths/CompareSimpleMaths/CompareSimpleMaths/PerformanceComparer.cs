using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    internal class PerformanceComparer<T, K>
    {
        //T Value1;
        //K Value2;

        //public PerformanceComparer(T value1, K value2)
        //{
        //    this.Value1 = value1;
        //    this.Value2 = value2;
        //}

        public void CompareAddition(T[] value1, K[] value2)
        {
            dynamic firstType = value1;
            dynamic secondType = value2;

            var stopwatch = new Stopwatch();

            var arrayOfFirstTypeLength = firstType.Length;
            var arrayOfSecondTypeLength = secondType.Length;

            stopwatch.Start();
            for (var i = 0; i < arrayOfFirstTypeLength; i++)
            {
                var result = 0;
                result += firstType[i];            
            }
            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;
            Console.WriteLine("Time consumed for adding of the first type values --> {0}", interval1);

            stopwatch.Restart();
            for (var i = 0; i < arrayOfSecondTypeLength; i++)
            {
                var result = 0;
                result += secondType[i];
            }
            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;
            Console.WriteLine("Time consumed for adding of the second type values --> {0}", interval2);
        }
    }
}
