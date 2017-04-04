using System;
using System.Numerics;
using System.Collections.Generic;

class problem3ConsoleApplication1
{
    static void Main()
    {

        BigInteger productOfDigits = 1;
        BigInteger productOfTen = 1;
        BigInteger finalProduct = 1;

        string number = string.Empty;
        bool isEven = true;
        int count = 1;

        while (true)
        {
            number = Console.ReadLine();

            if (number == "END")
            {
                break;
            }
            if (isEven)
            {
                if (number == "0")
                {
                    productOfDigits = 1;
                }
                else
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] != '0')
                        {
                            int digit = number[i] - '0';
                            productOfDigits *= digit;
                        }
                    }
                }

                finalProduct *= productOfDigits;
                productOfDigits = 1;
            }

            if (count == 10)
            {
                productOfTen = finalProduct;
                finalProduct = 1;
            }

            isEven = !isEven;
            count++;
        }

        if (count < 10)
        {
            Console.WriteLine(finalProduct);
        }
        else
        {
            Console.WriteLine(productOfTen);
            Console.WriteLine(finalProduct);
        }
    }

}


