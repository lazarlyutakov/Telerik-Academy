using System;

    class FourDigits
    {
        static void Main()
        {

        int number = Convert.ToInt32(Console.ReadLine());
        int a = ((number / 1000)%10);
        int b = ((number / 100) % 10);
        int c = ((number / 10) % 10);
        int d = (number% 10);

        int Sum = a + b + c + d;

        if (1000 <= number && number <= 9999) 
        {
            Console.WriteLine(Sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        } 

        else
        Console.WriteLine("Wrong input : your number should consist of 4 digits!");
         
    
        }
    }

