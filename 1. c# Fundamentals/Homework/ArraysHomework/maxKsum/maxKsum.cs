using System;

class maxKsum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int elements = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        int sum = 0;
        int temp = 0;

        for (int i = 0; i < number; i++)
        {

            array[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < number - 1; j++)
        {
            int minNum = array[j];

            for (int k = j + 1; k < number; k++)
            {
                if (array[k] < minNum)
                {
                    minNum = array[k];

                    if (minNum != array[j])
                    {
                        temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }
                }
            }
        }

        for (int i = 1; i <= elements; i++)
        {
            sum += array[number - i];
        }
        Console.WriteLine(sum);
    }
}

