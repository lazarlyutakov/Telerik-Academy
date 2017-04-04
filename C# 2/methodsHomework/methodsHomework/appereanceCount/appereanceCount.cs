using System;
using System.Linq;

class appereanceCount
{


    static void appearenceCount()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] array = inputArray.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int numbToCheck = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < sizeOfArray; i++)
        {
            if (array[i] == numbToCheck)
            {
                counter++;
            }

        }
        Console.WriteLine(counter);
    }
    static void Main()
    {

        appearenceCount();

    }
}

