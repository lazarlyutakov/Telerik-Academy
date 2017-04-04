using System;

class binaryShort
{

    static string result;


    static void Main()
    {

        short number = short.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine(NegativeNumbToBinary(number));
        }

        else
        {
            Console.WriteLine(PositiveToBinary(number));
        }
    }



    static string NegativeNumbToBinary(short num)
    {
        result = "";

        if (num < 0)
        {
            int toBeConvv = 0;
            toBeConvv = 32767 + num + 1;

            char firstDigit = '1';
            for (int i = toBeConvv; i > 0; i /= 2)
            {

                result = (toBeConvv % 2) + result;
                toBeConvv /= 2;

            }

            result = result.PadLeft(15, '0');
            result = firstDigit + result;


        }
        return result;
    }



    static string PositiveToBinary(short num)
    {
        result = "";

        for (short i = num; i > 0; i /= 2)
        {

            result = (num % 2) + result;
            num /= 2;

        }
        result = result.PadLeft(16, '0');
        return result;
    }
}