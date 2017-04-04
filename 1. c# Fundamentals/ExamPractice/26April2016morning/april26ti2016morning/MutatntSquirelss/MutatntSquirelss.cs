using System;

class MutatntSquirelss
{
    static void Main()
    {

        ulong trees = uint.Parse(Console.ReadLine());
        uint branches = uint.Parse(Console.ReadLine());
        uint squirels = uint.Parse(Console.ReadLine());
        uint avrgTails = uint.Parse(Console.ReadLine());

        ulong totalTails = trees * branches * squirels * avrgTails;

        Console.WriteLine("{0:f3}", totalTails % 2 == 0 ?
                                    totalTails * 376439 :
                                    totalTails / 7.00);
    }
}

