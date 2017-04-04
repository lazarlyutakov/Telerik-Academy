using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            long sumOdd = 1;
            long sumEven = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd *= Convert.ToInt32(num[i - 1]);
                }
                else
                {
                    sumEven *= Convert.ToInt32(num[i - 1]);
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("yes {0}", sumEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", sumEven, sumOdd);
            }
        }
    }
}
