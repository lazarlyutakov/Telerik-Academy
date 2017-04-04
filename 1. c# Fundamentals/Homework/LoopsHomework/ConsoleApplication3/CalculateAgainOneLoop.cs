using System;
using System.Numerics;

class Program
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

            if (i <= k)
            {
                factorielK *= i;
            }
        }

        answer = factorielN / factorielK;
        Console.WriteLine(answer);
    }
}

