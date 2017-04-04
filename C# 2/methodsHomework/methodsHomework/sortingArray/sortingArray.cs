using System;
using System.Linq;

class sortingArray
{
    static void SelectionSortOfArray(int size, int[] arrayToSort)
    {
        int temp = 0;

        for (int j = 0; j < size - 1; j++)
        {
            int minNum = arrayToSort[j];

            for (int k = j + 1; k < size; k++)
            {
                if (arrayToSort[k] < minNum)
                {
                    minNum = arrayToSort[k];

                    if (minNum != arrayToSort[j])
                    {
                        temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[k];
                        arrayToSort[k] = temp;
                    }
                }
            }
        }
        foreach (int num in arrayToSort)
        {
            Console.Write("{0} ", num);
        }
    }


    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] arrayToSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SelectionSortOfArray(size, arrayToSort);

        Console.WriteLine();
    }
}

