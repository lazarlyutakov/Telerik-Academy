using System;

class BitExchange
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        int p1 = p + 1;
        int p2 = p + k - 1;

        int q1 = q + 1;
        int q2 = q + k - 1;

        int firstBits = (N >> p) & 7;
        int secondBits = (N >> q) & 7;
        int maskFirstBits = 7 << p;
        int maskSecondBits = 7 << q;
        N = N & ~maskFirstBits | (secondBits << p);
        N = N & ~maskSecondBits | (firstBits << q);
        Console.WriteLine(N);

    }
}

