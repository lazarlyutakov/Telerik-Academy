using System;

class Program
{
    static void Main()
    {
        int integer;
        double real;
        string text;
        string output1 = Console.ReadLine();

        switch (output1)
        {
            case "integer":
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case "real":
                double number1 = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                double result = number1 + 1;
                Console.WriteLine("{0:f2}", result);
                break;
            case "text":

                string text1 = Console.ReadLine();
                Console.WriteLine(text1 + "*");
                break;
        }
    }
}

