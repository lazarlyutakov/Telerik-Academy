using System;

class binarySearch
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];


        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int target = int.Parse(Console.ReadLine());

        int first = 0;
        int last = number - 1;
        int middle = (first + last) / 2;
        bool match = false;

        while (first <= last && match != true)
        {

            middle = (first + last) / 2;

            if (array[middle] == target)
            {
                match = true;
            }

            else if (array[middle] > target)
            {
                last = middle - 1;
            }

            else if (array[middle] < target)
            {
                first = middle + 1;
            }
        }


        if (!match)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(middle);
        }

    }
}
