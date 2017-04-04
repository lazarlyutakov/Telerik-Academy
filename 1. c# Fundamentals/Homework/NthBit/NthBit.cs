using System;

class NthBit
{
    static void Main()
    {

        long P = Convert.ToInt64(Console.ReadLine());
        byte N = Convert.ToByte(Console.ReadLine());
        long k = (long)Math.Pow(2, 55);


        while(P>=0&&P<=k&&N<=55)
        {
            long mask = 1 << N;
            long result = P & mask;
            long result1 = result >> N;

            Console.WriteLine(result1);
            break;
        }

    }
}

