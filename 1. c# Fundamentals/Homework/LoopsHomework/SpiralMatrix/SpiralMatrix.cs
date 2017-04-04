using System;

    class SpiralMatrix
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        // Create a square matrix with (x, y) coordinates
        int[,] matrix = new int[n, n];

        // calculate the number of inner squares
        int innerSquares = (int)Math.Ceiling(n / 2.0);
        // store the size of the current square
        int currentSideLength = n;
        // this value will increment every time we fill in a number
        int counter = 1;

        // run this loop for each inner square
        for (int i = 0; i < innerSquares; i++)
        {
            // fill in top side
            for (int j = 0; j < currentSideLength; j++)
            {
                matrix[i + j, i] = counter++;
            }
            // fill in right side
            for (int j = 1; j < currentSideLength; j++)
            {
                matrix[n - 1 - i, i + j] = counter++;
            }
            // fill in bottom side
            for (int j = currentSideLength - 2; j > -1; j--)
            {
                matrix[i + j, n - 1 - i] = counter++;
            }
            // fill in left side
            for (int j = currentSideLength - 2; j > 0; j--)
            {
                matrix[i, i + j] = counter++;
            }
            // After finishing with the current square,  the next one has 2 less sides
            currentSideLength -= 2;
        }

        // print the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[j, i]);
            }
            Console.WriteLine();
        }
    }
    }

