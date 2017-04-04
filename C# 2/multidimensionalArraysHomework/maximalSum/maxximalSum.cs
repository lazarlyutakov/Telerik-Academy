using System;
using System.Linq;

class maxximalSum
{
    static void Main()
    {
        string[] matrixSize = Console.ReadLine().Split();

        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);

        int[,] matrix = new int[rows, cols];
        int largestSum = int.MinValue;
        int sum = 0;

        for (int row = 0; row < rows; row++)
        {
            int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // array for the current row;
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = tempArr[col];
            }
            Array.Clear(tempArr, 0, tempArr.Length);
        }

        for (uint row = 0; row < rows - 2; row++)
        {
            for (uint col = 0; col < cols - 2; col++)
            {

                for (uint i = row; i <= row + 2; i++)
                {
                    for (uint j = col; j <= col + 2; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                if (sum > largestSum)
                {
                    largestSum = sum;

                }
                sum = 0;
            }
        }
        Console.WriteLine(largestSum);
    }
}

