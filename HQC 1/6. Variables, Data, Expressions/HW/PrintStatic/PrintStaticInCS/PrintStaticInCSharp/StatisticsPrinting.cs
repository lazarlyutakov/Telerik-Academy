using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStaticInCSharp
{
    public class StatisticsPrinting
    {
        public void PrintStatistics(double[] arrayOfNumbers)
        {
            Console.WriteLine(GetMaxNumber(arrayOfNumbers));
            Console.WriteLine(GetMinNumber(arrayOfNumbers));
            Console.WriteLine(GetAverageNumber(arrayOfNumbers));
        }

        public double GetMaxNumber(double[] arrayOfNumbers)
        {
            double maxNumber = double.MinValue;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > maxNumber)
                {
                    maxNumber = arrayOfNumbers[i];
                }
            }
            return maxNumber;
        }

        public double GetMinNumber(double[] arrayOfNumbers)
        {
            double minNumber = double.MinValue;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] < minNumber)
                {
                    minNumber = arrayOfNumbers[i];
                }
            }
            return minNumber;
        }

        public double GetAverageNumber(double[] arrayOfNumbers)
        {
            double average = 0;
            double arraySum = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arraySum += arrayOfNumbers[i];
            }
            average = arraySum / arrayOfNumbers.Length;

            return average;

        }
    }
}
