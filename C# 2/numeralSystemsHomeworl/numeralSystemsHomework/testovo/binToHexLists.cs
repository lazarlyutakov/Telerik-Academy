using System;
using System.Collections.Generic;
using System.Numerics;


class BinaryToHexadecimalLists
{
    
    static void Main()
    {
        string bin = Console.ReadLine();
        char[] binInCharArr = bin.ToCharArray();
        BigInteger binToDec = FromBinToDec(binInCharArr);
        List<string> decToHex = FromDecToHex(binToDec);

        foreach (var item in decToHex)
        {
            Console.Write(item);
        }
    }
    
    static BigInteger FromBinToDec(char[] binaryInCharArray)
    {
        BigInteger dec = 0;
        Array.Reverse(binaryInCharArray);

        for (int i = 0; i < binaryInCharArray.Length; i++)
        {
            int fromCharToInt = int.Parse(binaryInCharArray[i].ToString());
            dec += fromCharToInt * (BigInteger)Math.Pow(2, i);
        }

        return dec;
    }
    
    static List<string> FromDecToHex(BigInteger decNumber)
    {
        List<string> hex = new List<string>();
        BigInteger remainder = 0;
        while (decNumber > 0)
        {
            if (decNumber % 16 == 0)
            {
                hex.Add("0");
            }
            if (decNumber % 16 != 0)
            {
                remainder = decNumber % 16;

                switch (remainder.ToString())
                {
                    case "10":
                        hex.Add("A");
                        break;
                    case "11":
                        hex.Add("B");
                        break;
                    case "12":
                        hex.Add("C");
                        break;
                    case "13":
                        hex.Add("D");
                        break;
                    case "14":
                        hex.Add("E");
                        break;
                    case "15":
                        hex.Add("F");
                        break;
                    default:
                        hex.Add(remainder.ToString());
                        break;
                }
            }
            decNumber /= 16;
        }
        hex.Reverse();
        return hex;
    }
}