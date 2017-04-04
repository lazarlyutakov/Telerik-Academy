using System;

class reverseNumbers
{

    static char[] ReverseNumbers(decimal input)
    {
        string digits = Convert.ToString(input);
        char[] reversedNumber = new char[digits.Length];

        for (int i = 0, j = digits.Length - 1; i < digits.Length; j--, i++)
        {
            reversedNumber[j] = digits[i];
        }
        return reversedNumber;
    }


    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine(ReverseNumbers(input));
    }
}

