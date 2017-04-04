using System;
using System.Numerics;

class binaryToDec
{
    static void Main()
    {
        string binary = Console.ReadLine();
        BigInteger binaryNum = BigInteger.Parse(binary);


        BigInteger digit = 0;
        BigInteger convert = 0;

        for (int i = 0; i < binary.Length; i++)
        {

            digit = binaryNum % 10;
            binaryNum /= 10;
            convert = convert + digit * (BigInteger)Math.Pow(2, i);

        }
        Console.WriteLine(convert);
    }
}

