using System;


    class Trailing0inN
    {
        static void Main()
        {

        int number = int.Parse(Console.ReadLine());
        int counter = 0;
      

        for(int i = 1; Math.Pow(5, i) < number; i++ )
        {         
           
            counter += number / (int)Math.Pow(5, i);
        }

        Console.WriteLine(counter);
        }
    }

