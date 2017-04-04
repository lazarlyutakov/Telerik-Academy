using System;
using System.Linq;

class integerCalculation
{

    static int MinimalInteger(int[] array)
    {
        int minNumb = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minNumb)
            {
                minNumb = array[i];
            }
        }
        return minNumb;
    }


    static int MaximalInteger(int[] array)
    {
        int maxNumb = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNumb)
            {
                maxNumb = array[i];
            }
        }
        return maxNumb;
    }


    static double Average(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double average = (double)sum / array.Length;

        return average;
    }


    static int SumOfInts(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }



    static long ProductOfInt(int[] array)
    {
        long product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }



    static void Main()
    {

        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(MinimalInteger(array));
        Console.WriteLine(MaximalInteger(array));
        Console.WriteLine("{0:f2}", Average(array));
        Console.WriteLine(SumOfInts(array));
        Console.WriteLine(ProductOfInt(array));
    }
}

