using System;
using System.Numerics;


class oneSystemToAnother
{

    static int sNumSystem;
    static int dNumSystem;
    static string numberToConv;
    static ulong numbInDec;

    static void Main()
    {
        sNumSystem = int.Parse(Console.ReadLine());
        numberToConv = Console.ReadLine();
        dNumSystem = int.Parse(Console.ReadLine());

        numbInDec = SnumbSystToDec(numberToConv);
        Console.WriteLine(DecNumSystToD(numbInDec));
    }

    static ulong SnumbSystToDec(string num)
    {
        int digit = 0;
        ulong temp = 0;
        int psnInd = 0;

        for (int i = 0; i < numberToConv.Length; i++)
        {
            if (numberToConv[i] >= 'A' && numberToConv[i] <= 'Z')
            {
                digit = numberToConv[i] - 'A' + 10;
                psnInd = numberToConv.Length - i - 1;
                temp += (ulong)digit * (ulong)BigInteger.Pow(sNumSystem, psnInd);
            }

            else if (numberToConv[i] >= '0' && numberToConv[i] <= '9')
            {
                digit = numberToConv[i] - '0';
                psnInd = numberToConv.Length - i - 1;
                temp += (ulong)digit * (ulong)BigInteger.Pow(sNumSystem, psnInd);
            }
        }
        return temp;
    }


    static string DecNumSystToD(ulong num)
    {
        ulong temp = 0;
        string result = string.Empty;
        numbInDec = SnumbSystToDec(numberToConv);

        if (numbInDec == 0)
        {
            result = "0";
        }

        else
        {
            while (numbInDec != 0)
            {
                temp = numbInDec % (ulong)dNumSystem;
                numbInDec = numbInDec / (ulong)dNumSystem;
                if (temp > 9)
                {
                    char symbol = (char)((temp - 10) + 'A');
                    result = (symbol.ToString()) + result;
                }
                else
                {
                    result = temp + result;
                }
            }
        }
        return result;
    }
}

