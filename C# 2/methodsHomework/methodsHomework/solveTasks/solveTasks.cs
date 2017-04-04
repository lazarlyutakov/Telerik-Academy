using System;
using System.Linq;

    class solveTasks
    {

    static char[] Reverse(int number)
    {
        string digits = Convert.ToString(number);
        char[] reversedNumber = new char[digits.Length];

        for (int i = 0, j = digits.Length - 1; i < digits.Length; j--, i++)
        {
            reversedNumber[j] = digits[i];
        }
        return reversedNumber;
    }



    static int Average(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        int average = sum / array.Length;

        return average;
    }



    static int Equasion(int a, int b, int x)
    {
        int result = a * x + b;
        return result;
    }



        static void Main()
        {
        Console.WriteLine("For reversing numbers type --> 1 ");
        Console.WriteLine("For calculatig average sum type --> 2 ");
        Console.WriteLine("For calculating a * x + b type --> 3 \n");
        Console.Write("Choose the kind of operation you would like to perform : ");
        int input = int.Parse(Console.ReadLine());

        if(input == 1)
        {
            Console.Write("\nEnter the number : ");
            int numb = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("The reversed number is : ");
            Console.WriteLine(Reverse(numb));
        }
        else if (input == 2)
        {
            Console.Write("Enter your integers : ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("The average is : ");
            Console.WriteLine(Average(array));
        }
        else if(input == 3)
        {
            Console.Write("Enter a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("The result is :");
            Console.WriteLine(Equasion(a,b, x));
        }


        }
    }

