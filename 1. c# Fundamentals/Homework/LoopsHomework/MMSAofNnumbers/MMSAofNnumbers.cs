using System;
using System.Linq;

class MMSAofNnumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double[] sequence = new double[number];


        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("min={0:F2}", sequence.Min());
        Console.WriteLine("max={0:F2}", sequence.Max());
        Console.WriteLine("sum={0:F2}", sequence.Sum());
        Console.WriteLine("avg={0:F2}", sequence.Average());


    }
}

