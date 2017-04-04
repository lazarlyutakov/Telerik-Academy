using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class DivisibleBy7and3
    {
        static void Main(string[] args)
        {
            Console.Write("How long do you want to be the array ?  ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayToInspect = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arrayToInspect[i] = (int.Parse(Console.ReadLine()));
            }

            CheckWithLambda(arrayToInspect);
            CheckWithLINQ(arrayToInspect);
        } 


            public static void CheckWithLambda(int[] arrayToInspect)
        { 
            var divisibleNums = arrayToInspect.Where(n => (n % 3 == 0) && (n % 7 == 0)).ToList();

            Console.WriteLine("Integers divisible by 3 and 7 ( ordered with Lambda expression ) are  : ");

            foreach (var item in divisibleNums)
            {

                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        public static void CheckWithLINQ(int[] arrayToInspect)
        {
            var divisibleNums =
                from numbers in arrayToInspect
                where (numbers % 3 == 0) && (numbers % 7 == 0)
                select numbers;

            Console.WriteLine("Integers divisible by 3 and 7 ( ordered with LINQ ) are: ");

            foreach (var numbers in divisibleNums)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine();
        }

            
        }
    }

