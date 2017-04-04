using System;

class sumOfEvenDivisors
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = 2; j <= secondNumber; j++)
            {
                if (i % j == 0 && j % 2 == 0)
                {
                    sum += j;

                }
            }

        }

        Console.WriteLine(sum);
    }
}

