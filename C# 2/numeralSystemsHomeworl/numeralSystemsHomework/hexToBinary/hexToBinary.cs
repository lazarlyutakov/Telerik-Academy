using System;
using System.Numerics;

class hexToBinary
{
    static long hexToDec(string hexInput)
    {

        long digit = 0;
        long pow = hexInput.Length - 1;
        long result = 0;

        for (int i = 0; i < hexInput.Length; i++)
        {
            char hex = hexInput[i];
            switch (hex.ToString())
            {
                case "0": digit = 0; break;
                case "1": digit = 1; break;
                case "2": digit = 2; break;
                case "3": digit = 3; break;
                case "4": digit = 4; break;
                case "5": digit = 5; break;
                case "6": digit = 6; break;
                case "7": digit = 7; break;
                case "8": digit = 8; break;
                case "9": digit = 9; break;
                case "A": digit = 10; break;
                case "B": digit = 11; break;
                case "C": digit = 12; break;
                case "D": digit = 13; break;
                case "E": digit = 14; break;
                case "F": digit = 15; break;

            }

            result += digit * (long)Math.Pow(16, pow);
            pow--;
        }
        return result;
    }


    static string DecToBinary(BigInteger decVal)
    {

        string finalResult = "";

        for (BigInteger i = decVal; i > 0; i /= 2)
        {

            finalResult = (decVal % 2) + finalResult;
            decVal /= 2;

        }
        return finalResult;

    }


    static void Main()
    {
        string hexInput = Console.ReadLine();
        BigInteger hexTodecimal = hexToDec(hexInput);

        Console.WriteLine(DecToBinary(hexTodecimal));
    }
}

