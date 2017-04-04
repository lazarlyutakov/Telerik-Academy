using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score >= 1 && score <= 3)
        {
            Console.WriteLine(score * 10);
        }

        if (score >= 4 && score <= 6)
        {
            Console.WriteLine(score * 100);
        }

        if (score >= 7 && score <= 9)
        {
            Console.WriteLine(score * 1000);
        }

        if (score <= 0 || score > 9)
        {
            Console.WriteLine("invalid score");
        }



    }
}

