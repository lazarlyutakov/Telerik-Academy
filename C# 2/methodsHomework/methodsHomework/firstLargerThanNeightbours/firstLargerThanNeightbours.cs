using System;
using System.Linq;

class firstLargerThanNeightbours
{
    //static int[] FillUpArray()
    //{
    //    string inputArray = Console.ReadLine();
    //    int[] array = inputArray.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
    //    return array;
    //}

    static int FirstLarger(int[] array)
    {
        int index = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;
    }


    static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] array = inputArray.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(FirstLarger(array));
    }
}

