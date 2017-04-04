using System;

class Depth_First_Search
{
    public static void Main(string[] args)
    {
        int[,] array = new int[,] { {1,3,2,2,2,4},
                                    {3,3,3,2,4,4},
                                    {4,3,1,2,3,3},
                                    {4,3,1,3,3,1},
                                    {4,3,3,3,1,1} };
        bool[,] calculated = new bool[array.GetLength(0), array.GetLength(1)];
        int bestCount = 0;
        int indexRow = 0;
        int indexCol = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (!calculated[row, col])
                {
                    int count = DepthFirstSearch(array, row, col, calculated);
                    if (bestCount < count)
                    {
                        bestCount = count;
                        indexRow = row;
                        indexCol = col;
                    }
                }

            }
        }
        Console.WriteLine("The len of largest area in matrix is {0}", bestCount);
        Console.WriteLine("The element is {2} on position {0},{1} ", indexRow, indexCol, array[indexRow, indexCol]);
    }

    static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
    {
        int result = 1;
        calc[row, col] = true;
        if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
        {
            result += DepthFirstSearch(array, row - 1, col, calc);
        }
        if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
        {
            result += DepthFirstSearch(array, row + 1, col, calc);
        }
        if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
        {
            result += DepthFirstSearch(array, row, col - 1, calc);
        }
        if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
        {
            result += DepthFirstSearch(array, row, col + 1, calc);
        }
        return result;
    }
}


