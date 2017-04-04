using System;

class maximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int sum = 0;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {

            sum += array[i];

            if (sum < 0)
            {
                sum = 0;
            }
            else if (result < sum)
            {
                result = sum;
            }

        }

        Console.WriteLine(result);

    }
}

