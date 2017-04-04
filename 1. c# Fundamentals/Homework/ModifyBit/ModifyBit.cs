using System;

class ModifyBit
{
    static void Main()
    {

        ulong N = Convert.ToUInt64(Console.ReadLine());
        byte P = Convert.ToByte(Console.ReadLine());
        byte v = Convert.ToByte(Console.ReadLine());

        if (v == 0 && P >= 0 && P < 64)
        {
            ulong mask = (ulong)~(1 << P);
            ulong result = (ulong)(N & mask);

            Console.WriteLine(result);

        }
        else if (v == 1 && P >= 0 && P < 64)
        {
            ulong mask = (ulong)(1 << P);
            ulong result = (ulong)(N | mask);

            Console.WriteLine(result);
        }

    }
}

