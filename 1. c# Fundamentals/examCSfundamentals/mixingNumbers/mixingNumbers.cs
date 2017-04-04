using System;

class mixingNumbers
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        int product = 0;
        int difference = 0;

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0, j = i + 1; i < number && j < number; i++, j++)
        {
            product = (array[i] % 10) * (array[j] / 10);
            Console.Write(product + " ");

        }

        Console.WriteLine();

        for (int i = 0, j = i + 1; i < number && j < number; i++, j++)
        {
            difference = Math.Abs(array[i] - array[j]);
            Console.Write(difference + " ");
        }
    }
}

