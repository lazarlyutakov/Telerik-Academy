using System;

class frequentNumber
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int counter = 0;
        int maxCount = counter;
        int mostFrequent = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int final = array[0];


        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                    mostFrequent = array[j];
                }
            }

            if (counter > maxCount)
            {
                maxCount = counter;
                final = mostFrequent;
            }

            counter = 0;
        }

        Console.WriteLine("{0} ({1} times)", final, maxCount);
    }
}


