namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class, that contains all the methods, required from the condition of the task.
    /// </summary>
    /// <typeparam name="T">First data type</typeparam>
    /// <typeparam name="K">Second data type</typeparam>
    internal class PerformanceComparer<T, K>
    {

        public void CompareAddition(T tValue1, T tValue2, K kValue1, K kValue2)
        {
            dynamic firstTypeFirstNumb = tValue1;
            dynamic firstTypeSecondNumb = tValue2;
            dynamic secondTypeFirstNumb = kValue1;
            dynamic secondTypeSecondNumb = kValue2;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = firstTypeFirstNumb + firstTypeSecondNumb;

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for adding of the first type values --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = secondTypeFirstNumb + secondTypeSecondNumb;

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for adding of the second type values --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareSubstract(T tValue1, T tValue2, K kValue1, K kValue2)
        {
            dynamic firstTypeFirstNumb = tValue1;
            dynamic firstTypeSecondNumb = tValue2;
            dynamic secondTypeFirstNumb = kValue1;
            dynamic secondTypeSecondNumb = kValue2;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = firstTypeFirstNumb - firstTypeSecondNumb;

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for substracting of the first type values --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = secondTypeFirstNumb - secondTypeSecondNumb;

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for substracting of the second type values --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareMultiplication(T tValue1, T tValue2, K kValue1, K kValue2)
        {
            dynamic firstTypeFirstNumb = tValue1;
            dynamic firstTypeSecondNumb = tValue2;
            dynamic secondTypeFirstNumb = kValue1;
            dynamic secondTypeSecondNumb = kValue2;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = firstTypeFirstNumb * firstTypeSecondNumb;

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for multiplication of the first type values --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = secondTypeFirstNumb * secondTypeSecondNumb;

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for multiplication of the second type values --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareDividing(T tValue1, T tValue2, K kValue1, K kValue2)
        {
            dynamic firstTypeFirstNumb = tValue1;
            dynamic firstTypeSecondNumb = tValue2;
            dynamic secondTypeFirstNumb = kValue1;
            dynamic secondTypeSecondNumb = kValue2;

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var firstResult = firstTypeFirstNumb / firstTypeSecondNumb;

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for dividing of the first type values --> {0}", interval1);

            stopwatch.Restart();

            var secondResult = secondTypeFirstNumb / secondTypeSecondNumb;

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for dividing of the second type values --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }

        public void CompareIncemet(T value1, K value2)
        {
            dynamic firstValue = value1;
            dynamic secondValue = value2;
            int limitOfLoop = 100;

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < limitOfLoop; i++)
            {
                firstValue += i;
            }

            stopwatch.Stop();
            var interval1 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for increment of the first value --> {0}", interval1);

            stopwatch.Restart();
            for (int i = 0; i < limitOfLoop; i++)
            {
                secondValue += i;
            }

            stopwatch.Stop();
            var interval2 = stopwatch.Elapsed;

            Console.WriteLine("Time consumed for increment of the second value --> {0}", interval2);
            Console.WriteLine("\r\n" + new string('#', 80) + "\r\n");
        }
    }
}
