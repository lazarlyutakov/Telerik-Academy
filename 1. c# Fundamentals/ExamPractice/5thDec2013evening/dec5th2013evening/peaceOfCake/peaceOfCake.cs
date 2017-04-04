using System;

class peaceOfCake
{
    static void Main()
    {

        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());
        
        long firstCake = (a / b);
        long secondCake = (c / d);
        long nominator = ((a * d) + (b * c));
        long denominator = b * d;
        decimal amountOfCakes = ((decimal)(nominator) / ( denominator));

        if (amountOfCakes >= 1)
        {
            Console.WriteLine((long)amountOfCakes);
            Console.WriteLine(nominator + "/" + denominator);
        }

        else if (amountOfCakes < 1)
        {
            Console.WriteLine("{0:f22}", amountOfCakes);
            Console.WriteLine(nominator + "/" + denominator);

        }
    }
}

