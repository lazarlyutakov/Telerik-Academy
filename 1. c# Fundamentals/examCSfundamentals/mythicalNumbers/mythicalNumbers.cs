using System;

class mythicalNumbers
{
    static void Main()
    {

        int input = int.Parse(Console.ReadLine());
        int thirdDigit = input % 10;
        int secondDigit = (input / 10) % 10;
        int firstDigit = (input / 100) % 10;
        double result = 0;

        if (thirdDigit == 0)
        {
            result = (double)secondDigit * (double)firstDigit;
        }

        else if (thirdDigit >= 0 && thirdDigit <= 5)
        {
            result = ((double)secondDigit * (double)firstDigit) / thirdDigit;
        }
        else if (thirdDigit > 5)
        {
            result = ((double)(secondDigit) + (double)(firstDigit)) * thirdDigit;
        }

        Console.WriteLine("{0:f2}", result);
    }
}

