using System;


class primeNumbers
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
       bool[] array = new bool[number];

        int max = 2;
        int i = 0;

        for (i = 0; i < number; i++)
        {
            array[i] = true;
        }

        for (i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i])
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = false;
                }
            }
        }


        for (i = 2; i < number; i++)
        {
            if (array[i] && max < i)
            {
                max = i;

            }

        }

        Console.WriteLine(max);
    }
}

