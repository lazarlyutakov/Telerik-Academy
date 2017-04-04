using System;

class fillTheMatrix
{
    static void Main()
    {

        int size = int.Parse(Console.ReadLine());
        char type = Convert.ToChar(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int count = 1;


        if (type == 'a')
        {

            for (int col = 0; col < size; col++)
            {

                for (int row = 0; row < size; row++, count++)
                {
                    matrix[row, col] = count;
                }
            }
        }

        else if (type == 'b')
        {

            for (int col = 0; col < size; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < size; row++, count++)
                    {
                        matrix[row, col] = count;
                    }
                }
                else
                {
                    for (int row = size - 1; row >= 0; row--)
                    {
                        matrix[row, col] = count++;
                    }

                }

            }
        }

        else if (type == 'c')
        {
            for (int bottomRow = size - 1; bottomRow >= 0; bottomRow--)
            {
                for (int col = 0; col < size - bottomRow; col++, count++)
                {
                    if (col == 0)
                    {
                        matrix[bottomRow, col] = count;
                    }
                    else
                    {
                        matrix[(bottomRow + col), col] = count;
                    }
                }
            }

            for (int col = 1; col < size; col++)
            {
                for (int row = 0; row < size - col; row++, count++)
                {
                    if (row == 0)
                    {
                        matrix[row, col] = count;
                    }

                    else
                    {
                        matrix[row, (col + row)] = count;
                    }
                }
            }
        }


        else if (type == 'd')
        {
            for (int i = 0; i <= (size / 2); i++)
            {
                for (int row = i; row < size - i ; row++, count++)
                {
                    matrix[row, i] = count;
                }
                for (int col = i + 1; col < size - i ; col++, count++)
                {
                    matrix[(size - i - 1), col] = count;
                }
                for (int row1 = size - i - 2; row1 > i; row1--, count++)
                {
                    matrix[row1, (size - i - 1)] = count;
                }
                for (int col1 = size - i - 1; col1 > i; col1--, count++)
                {
                    if (matrix[i, col1] == 0)
                    {
                        matrix[i, col1] = count;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }


        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col == (size - 1))
                {
                    Console.Write(matrix[row, col]);
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}

