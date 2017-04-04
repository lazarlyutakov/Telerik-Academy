using System;
using System.Linq;

namespace sumOfIntegers
{
    class Program
    {
        static void Main()
        {
            int[] integersToSum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < integersToSum.Length; i++)
            {
                sum += integersToSum[i];
            }
            Console.WriteLine(sum);
        }
    }
}

////// VARIANT DVE


//    using System;
 
//   class CalculateValuesSum
//{
//    static void CalculateSum(string inputNumber)
//    {
//        string[] numbers = inputNumber.Split(' ');

//        int sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int temp = Convert.ToInt32(numbers[i]);
//            sum = sum + temp;
//        }
//        Console.WriteLine(sum);
//    }

//    static void Main(string[] args)
//    {
//
//        string inputNumber = Console.ReadLine();

//        CalculateSum(inputNumber);
//    }
//}






