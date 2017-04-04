using System;
using System.Linq;

class largerThanNeightbours
{


    static void LargerThanNeightbours()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] array = inputArray.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int counter = 0;

        for (int i = 1; i < sizeOfArray - 1; i++)
        {
            if (array[i + 1] < array[i] && array[i] > array[i - 1])
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }


    static void Main()
    {
        LargerThanNeightbours();
    }
}

