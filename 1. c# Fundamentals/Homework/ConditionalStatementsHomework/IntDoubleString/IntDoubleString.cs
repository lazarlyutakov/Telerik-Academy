using System;

    class IntDoubleString
    {
        static void Main()
        {
        int integer;
        double real;
        string text;
       string output1=Console.ReadLine();
      
        if(output1=="integer")
        {
            int number = int.Parse(Console.ReadLine());

            int result = number + 1;
            Console.WriteLine(result);
        }

        else if(output1=="real")
        {
            double number1 = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double result1 = number1 + 1;
            Console.WriteLine("{0:f2}",result1);
        }

        else if(output1=="text")
        {
            string text1 = Console.ReadLine();
            Console.WriteLine(text1+"*");
        }
        
        }
    }
