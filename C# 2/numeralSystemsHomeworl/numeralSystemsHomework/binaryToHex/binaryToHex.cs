using System;
using System.Numerics;

class BinaryToHex
{
    static string binary;
    static BigInteger binaryToDec;
    static string decToHex;
    static string hexVal;
    static char[] finalResult;

    static void Main()
    {
        binary = Console.ReadLine();
        BinaryToDec();
        DecToHex();
        ReverseResult();
        Console.WriteLine(finalResult);

    }

    static void BinaryToDec()
    {
        BigInteger binaryNum = BigInteger.Parse(binary);
        BigInteger digit = 0;
        BigInteger convert = 0;

        for (int i = 0; i < binary.Length; i++)
        {

            digit = binaryNum % 10;
            binaryNum /= 10;
            convert = convert + digit * (ulong)Math.Pow(2, i);
        }
        binaryToDec = convert;
    }


    static void DecToHex()
    {
        ulong remainder = 0;
        string result = "";

        for (BigInteger i = binaryToDec; i > 0; i /= 16)
        {

            remainder = (ulong)binaryToDec % 16;
            hexVal = Convert.ToString(remainder);

            switch (remainder)
            {
                case 10: hexVal = "A"; break;
                case 11: hexVal = "B"; break;
                case 12: hexVal = "C"; break;
                case 13: hexVal = "D"; break;
                case 14: hexVal = "E"; break;
                case 15: hexVal = "F"; break;

            }
            result += hexVal;
            binaryToDec /= 16;
        }

        decToHex = result;
    }


    static void ReverseResult()
    {

        char[] reversedNumber = new char[decToHex.Length];

        for (int i = 0, j = decToHex.Length - 1; i < decToHex.Length; j--, i++)
        {
            reversedNumber[j] = decToHex[i];
        }
        finalResult = reversedNumber;
    }
}
