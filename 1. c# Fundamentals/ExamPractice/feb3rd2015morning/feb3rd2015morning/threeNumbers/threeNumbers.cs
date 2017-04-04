using System;

class threeNumbers
{
    static void Main()
    {

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int maxNumbers = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
        int minNumbers = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
        double avrg = ((double)firstNumber + (double)secondNumber + (double)thirdNumber) / 3;

        Console.WriteLine(maxNumbers);
        Console.WriteLine(minNumbers);
        Console.WriteLine("{0:f2}", avrg);

    }
}

