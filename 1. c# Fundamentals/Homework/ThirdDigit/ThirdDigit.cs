using System;

    class ThirdDigit
    {
    static void Main()
    {

        uint a = Convert.ToUInt32(Console.ReadLine());
        uint result = (a / 100) % 10;

        if (result == 7) 

        {
            Console.WriteLine("true");
        }

        else
        
            Console.WriteLine("false" + " " + result);
           
        }
    }

