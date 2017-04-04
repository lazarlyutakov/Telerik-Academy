using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger answer = 0;

        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;

        }

        for (int j = 1; j <= k; j++)
        {
            factorielK *= j;
        }

        answer = factorielN / factorielK;
        Console.WriteLine(answer);
    }
}

