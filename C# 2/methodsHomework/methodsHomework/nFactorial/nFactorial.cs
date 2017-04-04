using System;
using System.Numerics;

class nFactorial
{

    static BigInteger CalculatingFactorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= number; i++)
        {

            factorial *= i;
        }

        return factorial;
    }

    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculatingFactorial(input));
    }
}

