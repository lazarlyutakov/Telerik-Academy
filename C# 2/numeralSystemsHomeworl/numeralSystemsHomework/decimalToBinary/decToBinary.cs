using System;
using System.Numerics;

class DecimalToBinary
{
    static void Main()
    {

        BigInteger decNumber = BigInteger.Parse(Console.ReadLine());

        BigInteger convert = 0;
        string result = "";

        for (BigInteger i = decNumber; i > 0; i /= 2)
        {

            result = (decNumber % 2) + result;
            decNumber /= 2;

        }

        Console.WriteLine(result);
    }
}


