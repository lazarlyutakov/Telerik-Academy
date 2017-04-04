using System;
using System.Collections.Generic;
using System.Linq;

class binarySearch
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        int i = 0;

        for (i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int result = Array.BinarySearch(array, k);

        if (array[0] > k)
        {
            Console.WriteLine(" There is not such number ! ");
        }

        else
        {
            if (result >= 0)
            {
                Console.WriteLine(array[result]);
            }

            else
            {
                Console.WriteLine(array[-result - 2]);
            }
        }

    }
}

