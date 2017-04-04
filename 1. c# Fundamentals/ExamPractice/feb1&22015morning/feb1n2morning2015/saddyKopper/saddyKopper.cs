using System;

class saddyKopper
{
    static void Main()
    {

        string number = (Console.ReadLine());
        long convNumber = long.Parse(number);
        int sum = 0;
        int sumSofar = 1;
        long counter = 0;
        int finalSum = 1;

        for (long i = (convNumber / 10); i >= 0; i /= 10)
        {
            if (i == 0)
            {
                break;
            }
            for (int j = 0; j < i.ToString().Length; j++)
            {
                if (j % 2 == 0)
                {
                    sum += (number[j] - '0');
                }

            }
            if (sum != 0)
            {
                sumSofar *= sum;
            }
            sum = 0;
        }

        while ((sumSofar).ToString().Length > 1)

        {

            for (long k = (sumSofar / 10); k >= 0; k /= 10)
            {
                
                if (k == 0)
                {
                    break;
                }
                for (int p = 0; p < k.ToString().Length; p++)
                    
                {
                    if (p % 2 == 0)
                    {
                        sum += (sumSofar.ToString()[p] - '0');
                    }
                }
                if (sum != 0)
                {
                    finalSum *= sum;
                    sumSofar = finalSum;

                }
                sum = 0;
            }
        }

        if ((counter + 1) < 10)
        {
            Console.WriteLine(counter + 1);
            Console.WriteLine(finalSum);
        }
        else
        {
            Console.WriteLine(finalSum);
        }
    }
}
