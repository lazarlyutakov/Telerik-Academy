using System;


class SumOfNnumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        if (n >= 1 && n <= 200)
        {
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                //input vzema vyvedenite chisla ; n e broqt na vyvedenite chisla ;
                sum += input;
            }
        }

        Console.WriteLine(sum);
    }


}
