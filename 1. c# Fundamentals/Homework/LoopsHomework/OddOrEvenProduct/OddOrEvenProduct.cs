using System;

class OddOrEvenProduct
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string[] number = Console.ReadLine().Split(' ');

        long evenProd = 1;
        long oddProd = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                oddProd *= long.Parse(number[i-1]);
            }
            else
            {
                evenProd *= long.Parse(number[i-1]);
            }
        }

        if (evenProd == oddProd)
        {
            Console.WriteLine("yes {0}", evenProd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProd, oddProd);
        }


    }
}

