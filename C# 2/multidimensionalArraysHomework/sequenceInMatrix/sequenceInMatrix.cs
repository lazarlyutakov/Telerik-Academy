using System;
using System.Linq;

class sequenceInMatrix
{
    static void Main()
    {

        string[] matrixSize = Console.ReadLine().Split();

        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);

        int[,] matrix = new int[rows, cols];
        int result = 0;
        int counterRow = 0;
        int counterCol = 0;

        for (int row = 0; row < rows; row++)
        {
            int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = tempArr[col];
            }
            Array.Clear(tempArr, 0, tempArr.Length);
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                while (row + counterRow < matrix.GetLength(0))
                {
                    if (matrix[row, col] == matrix[row + counterRow, col])
                    {
                        counterRow++;
                    }
                    else
                    {
                        break;
                    }
                    if (counterRow + 1 > result)
                    {
                        result = counterRow;
                    }
                }

                while (col + counterCol < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row, col + counterCol])
                    {
                        counterCol++;
                    }
                    else
                    {
                        break;
                    }
                    if (counterCol + 1 > result)
                    {
                        result = counterCol;
                    }
                    counterRow = 0;
                }

                while (row + counterRow < matrix.GetLength(0) && col + counterRow < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row + counterRow, col + counterRow])
                    {
                        counterRow++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counterRow + 1 > result)
                {
                    result = counterRow;
                }
            }
        }
        Console.WriteLine(result);
    }
}

