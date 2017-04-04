using System;

class PrimeDigit
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool isNPrime = true;
        if ( N <= 100)
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isNPrime = false;
                    break;
                }
            }
            if (N == 1 || N == 0 || N<0)
            {
                isNPrime = false;
            }
            Console.WriteLine(isNPrime.ToString().ToLower());
        }
    }
}









