using System;

class GCD
{
    static void Main()
    {
        string[] ab = Console.ReadLine().Split(' ');

        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);
        int intDiv = 0;
        int remainder = 1;
        while (remainder != 0)
        {
            remainder = a % b;
            intDiv = a / b;
            a = b;
            b = remainder;
            
        }
        Console.WriteLine(a);
    }
}

