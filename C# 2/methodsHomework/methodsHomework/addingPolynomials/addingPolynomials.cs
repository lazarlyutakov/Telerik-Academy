using System;
using System.Linq;
using System.Text;

class addingPolynomials
{
    static void SumOfPolynoms(int[] first, int[] second)
    {
 
        StringBuilder result = new StringBuilder();

        for (int i = 0, j = 0; i < first.Length && j < second.Length; i++, j++)
        {
            result.Append(first[i] + second[j] + " ");
          
        }
        Console.WriteLine(result);
    }


    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] firstPolynom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondPolynom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SumOfPolynoms(firstPolynom, secondPolynom);

    }
}

