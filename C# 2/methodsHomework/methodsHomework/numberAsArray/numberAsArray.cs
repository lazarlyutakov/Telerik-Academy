using System;
using System.Linq;
using System.Text;

class numberAsArray
{

    
    static void SumOfTwoArrays(int[] sizeOfArrays, int[] firstArray, int[] secondArray)
    {
        StringBuilder result = new StringBuilder();
        int firstDigit = 0;
        int secondDigit = 0;
        int inMind = 0;
        int longerArray = Math.Max(firstArray.Length, secondArray.Length);

        for (int i = 0; i <= longerArray - 1; i++)
        {
            
            if (i <= sizeOfArrays[0] - 1)
            {
                firstDigit = firstArray[i];
            }
            else
            {
                firstDigit = 0;
            }
           
            if (i <= sizeOfArrays[1] - 1)
            {
                secondDigit = secondArray[i];
            }
            else
            {
                secondDigit = 0;
            }
            
            result.Append(((firstDigit + secondDigit + inMind) % 10) + " ");

            if ((firstDigit + secondDigit + inMind) > 9)
            {
                inMind = 1;
            }
            else
            {
                inMind = 0;
            }
        }
   
        Console.WriteLine(result);

    }


    static void Main()
    {

        int[] sizeOfArrays = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SumOfTwoArrays(sizeOfArrays, firstArray, secondArray);
        
    }
}

