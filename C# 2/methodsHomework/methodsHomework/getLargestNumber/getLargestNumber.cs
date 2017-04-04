using System;
using System.Linq;

class getLargestNumber
{


    static string getMax (string input)
    {
         input = Console.ReadLine();
        int[] array = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(array.Max());
        return input;
        
    }

    static void Main()
    {
        getMax("");
    }
}

