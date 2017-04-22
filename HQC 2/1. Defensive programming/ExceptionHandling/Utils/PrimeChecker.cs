namespace ExceptionHandling.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class PrimeChecker
    {
        public static bool CheckPrime(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("The number must be a positive number!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
