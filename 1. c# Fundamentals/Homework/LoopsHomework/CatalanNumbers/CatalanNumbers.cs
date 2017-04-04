using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nBy2 = 2 * n;
        int nPlusOne = n + 1;
        BigInteger factorieln = 1;
        BigInteger factorielnBy2 = 1;
        BigInteger factorielnPlusOne = 1;
        BigInteger answer = 0;

        for (int i = 1; i <= nBy2; i++)
        {
            factorielnBy2 *= i;

            if (i <= nPlusOne)
            {
                factorielnPlusOne *= i;
            }

            if (i <= n)
            {
                factorieln *= i;
            }

        }
        answer = factorielnBy2 / (factorielnPlusOne * factorieln);
        Console.WriteLine(answer);

    }
}

