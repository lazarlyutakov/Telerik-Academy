using System;

    class OddOrEven
    {
    static void Main()
        {

            int number;
            bool oddEven;

            number = Convert.ToInt32(Console.ReadLine());

            oddEven =(number % 2 == 0) ? true : false;
            Console.Write(oddEven? "even" + " " + number : "odd" + " " + number);
            Console.WriteLine();
        
        }
    }

