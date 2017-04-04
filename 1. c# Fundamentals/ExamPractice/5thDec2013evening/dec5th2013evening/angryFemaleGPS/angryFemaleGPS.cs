using System;

class angryFemaleGPS
{
    static void Main()
    {
        string number = Console.ReadLine();
        

        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if(number[i] == '-')
            {
                continue;
            }

            if (number[i] % 2 == 0)
            {
                sumEven += number[i] - '0';
            }
            else
            {
                sumOdd += number[i] - '0';
            }

        }

        if (sumEven > sumOdd)
        {
            Console.WriteLine("right " + sumEven);
        }

        else if (sumEven < sumOdd)
        {
            Console.WriteLine("left " + sumOdd);
        }

        else if (sumEven == sumOdd)
        {
            Console.WriteLine("straight " + sumOdd);
        }
    }
}

