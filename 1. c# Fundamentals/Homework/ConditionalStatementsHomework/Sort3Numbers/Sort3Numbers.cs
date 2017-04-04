using System;

class Sort3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b && b > c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        if (a > b && b < c && a > c)
        {
            Console.WriteLine("{0} {2} {1}", a, b, c);
        }
        if (a < b && b < c)
        {
            Console.WriteLine("{2} {1} {0}", a, b, c);
        }
        if (a > b && b <= c && a < c)
        {
            Console.WriteLine("{2} {0} {1}", a, b, c);
        }

        if (a < b && b > c && a > c)
        {
            Console.WriteLine("{1} {0} {2}", a, b, c);
        }
        if (a < b && b > c && a < c)
        {
            Console.WriteLine("{1} {2} {0}", a, b, c);
        }
        if (a == b && b == c && a == c)
        {
            Console.WriteLine("{1} {2} {0}", a, b, c);
        }
        else if (a > b && b == c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if (a < b && b == c)
        {
            Console.WriteLine("{1} {2} {0}", a, b, c);
        }

        else if (a == b && a > c)
        {
            Console.WriteLine("{1} {0} {2}", a, b, c);
        }
        else if (a == b && a < c)
            Console.WriteLine("{2} {1} {0}", a, b, c);
        else if (a == c && a > b)
        {
            Console.WriteLine("{0} {2} {1}", a, b, c);
        }
        else if (a == c && a < b)
        {
            Console.WriteLine("{1} {2} {0}", a, b, c);
        }
    }
}










