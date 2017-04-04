using System;


class First248
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result = 0;

        switch (b)
        {
            case 2:result = a % c; break;
            case 4: result = a + c; break;
            case 8: result = a * c; break;
        }

        if (result % 4 == 0)
        {
            Console.WriteLine(result / 4);
        }
        else
        {
            Console.WriteLine(result % 4);
        }

        Console.WriteLine(result);

    }
}

