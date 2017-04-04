using System;

    class DivideBy7and5
    {
        static void Main()
        {
        int number=Convert.ToInt32(Console.ReadLine());
        bool noReminder;

        noReminder = ((number % 5==0) && (number % 7==0)) ? true : false;
        Console.WriteLine(noReminder ? "true" + " " + number : "false" + " " + number);
        Console.WriteLine();
        }
    }
