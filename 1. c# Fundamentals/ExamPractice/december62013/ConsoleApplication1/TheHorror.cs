using System;


    class Program
    {
        static void Main(string[] args)
        {

        string n = (Console.ReadLine());
        int counter = 0;
        int sum = 0;

        for(int i = 0; i <= n.Length; i++ )
        {
            if (i % 2 == 0)
            {
                counter++;
                sum += counter; // ne raboti
            }
            else
                continue;
        }
        

        Console.Write(counter+" "); // raboti
        Console.WriteLine(sum);     // ne raboti
            
    }
    }

