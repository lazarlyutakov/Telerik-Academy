using System;
using System.Linq;

class largestAreaInMatrix
{

    static int DepthFirstSearch(int[,] matrix, int row, int col, bool[,] calcMatrix)
    {
        int result = 1;
        calcMatrix[row, col] = true;

        if ((row - 1 >= 0) && (matrix[row - 1, col] == matrix[row, col]) && !calcMatrix[row - 1, col])
        {
            result += DepthFirstSearch(matrix, row - 1, col, calcMatrix);
        }
        if ((row + 1 < matrix.GetLength(0)) && (matrix[row + 1, col] == matrix[row, col]) && !calcMatrix[row + 1, col])
        {
            result += DepthFirstSearch(matrix, row + 1, col, calcMatrix);
        }
        if ((col - 1 >= 0) && (matrix[row, col - 1] == matrix[row, col]) && !calcMatrix[row, col - 1])
        {
            result += DepthFirstSearch(matrix, row, col - 1, calcMatrix);
        }
        if ((col + 1 < matrix.GetLength(1)) && (matrix[row, col + 1] == matrix[row, col]) && !calcMatrix[row, col + 1])
        {
            result += DepthFirstSearch(matrix, row, col + 1, calcMatrix);
        }
        return result;
    }


    static void Main()
    {

        string[] matrixSize = Console.ReadLine().Split();
        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // array for the current row;
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = tempArr[col];
            }
            Array.Clear(tempArr, 0, tempArr.Length);
        }

        bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        int maxCount = 0;
       
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (!calculated[row, col])
                {
                    int count = DepthFirstSearch(matrix, row, col, calculated);
                    if (maxCount < count)
                    {
                        maxCount = count;                        
                    }
                }

            }
        }
        Console.WriteLine(maxCount);
    }
}


