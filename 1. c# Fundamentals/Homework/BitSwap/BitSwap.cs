using System;

class BitSwap
{
    static void Main()
    {
        uint n = Convert.ToUInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        int p1 = p + 1;
        int p2 = p + k - 1;

        int q1 = q + 1;
        int q2 = q + k - 1;

 
        int i;

        for (i = p; i < p+k; i++) 
        {
            int mask = 1 << i;
            uint biti = (uint)mask & n;
            uint bitValue = biti >> i;

            int mask2 = 1 << q;
            uint bitii = (uint)mask2 & n;
            uint bitValue2 = bitii >> q;

            if (bitValue == 0 && (p + k - 1)<32 && (q + k - 1) < 32 && p >= 0 && q >= 0)
            {
                int maskF = ~(1 << q);
                n = (uint)maskF & n;
                if (bitValue != bitValue2)
                {
                    int maskF1 = 1 << i;
                    n = (uint)maskF1 | n;
                }

            }
            else if (bitValue != 1 && (p + k - 1) < 32 && (q + k - 1) < 32 && p>=0 && q>=0)
            {
                int maskF = (1 << q);
                n = (uint)maskF | n;
                if (bitValue != bitValue2)
                {
                    int maskF1 = -(1 << i);
                    n = (uint)maskF1 & n;
                }
            }

            q++;


        }
        Console.WriteLine(n);
    }
}

