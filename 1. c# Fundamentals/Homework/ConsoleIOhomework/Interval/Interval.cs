using System;

class Interval
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int calc = 0;
        int i;

        for ( i = n + 1; i < m; i++) 
        {

            if (i % 5 == 0)
            {

                calc++;
            }
            
        }
        Console.WriteLine(calc);
    }
}

