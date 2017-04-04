using System;

    class decToHex
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

        Console.WriteLine(ReverseResult(result));
    }


    static char[] ReverseResult(string result)
    {

        char[] reversedNumber = new char[result.Length];

        for (int i = 0, j = result.Length - 1; i < result.Length; j--, i++)
        {
            reversedNumber[j] = result[i];
        }
        return reversedNumber;
    }
}
    

