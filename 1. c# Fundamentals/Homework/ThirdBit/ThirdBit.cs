using System;

class ThirdBit
{
    static void Main()
    {
        uint a = Convert.ToUInt32(Console.ReadLine());
        uint mask = (1 << 3);
        uint result = (a & mask);
        uint result1 = (result >> 3);

        Console.WriteLine(result1);
    }
}

