using System;

class DecimalToHex
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());
        long remainder = 0;
        string result = "";

        for (long i = decNum; i > 0; i /= 16)
        {

            remainder = decNum % 16;
            string hexVal = Convert.ToString(remainder);

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
            decNum /= 16;
        }

        Console.WriteLine(StringHelper.ReverseString(result));
    }

    static class StringHelper
    {

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}



