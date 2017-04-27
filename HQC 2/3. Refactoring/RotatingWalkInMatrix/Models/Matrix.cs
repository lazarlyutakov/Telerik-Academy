using GameFifteen.Contracts;
using System;

namespace GameFifteen.Models
{
    public class Matrix : IMatrix
    {
        private int[] vertical = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private int[] horizontal = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public Matrix(int matrixSize)
        {
            this.MatrixToPrint = new int[matrixSize, matrixSize];
            this.AmountOfNumbers = 1;
        }

        public int MatrixSize { get; set; }

        public int[,] MatrixToPrint { get; set; }

        public int AmountOfNumbers { get; set; }

        public void FindFreeCell(out int vertical, out int horizontal)
        {
            vertical = 0;
            horizontal = 0;

            for (int col = 0; col < this.MatrixToPrint.GetLength(0); col++)
            {
                for (int row = 0; row < this.MatrixToPrint.GetLength(0); row++)
                {
                    if (this.MatrixToPrint[col, row] == 0)
                    {
                        vertical = col;
                        horizontal = row;
                        return;
                    }
                }
            }
        }

        public void FillUpTheMatrix(int vertical, int horizontal, int matrixSize)
        {
            int directionCol = 1;
            int directionRow = 1;

            while (true)
            {
                this.MatrixToPrint[vertical, horizontal] = this.AmountOfNumbers;

                if (!this.CheckPossibleDirection(this.MatrixToPrint, vertical, horizontal))
                {
                    this.AmountOfNumbers++;
                    break;
                }

                while (this.IsOutOfMatrix(vertical, horizontal, directionRow, directionCol, matrixSize))
                {
                    this.ChangeDirection(ref directionCol, ref directionRow);
                }

                vertical += directionCol;
                horizontal += directionRow;
                this.AmountOfNumbers++;
            }
        }

        public void PrintMatrix()
        {
            var logger = new Logger();
            for (int row = 0; row < this.MatrixToPrint.GetLength(0); row++)
            {
                for (int col = 0; col < this.MatrixToPrint.GetLength(1); col++)
                {
                    logger.Write("{0,3}", this.MatrixToPrint[row, col]);
                }

                logger.WriteLine(string.Empty);
            }
        }

        public int FindDirection(int directionVertical, int directionHorizontal)
        {
            for (int directionCounter = 0; directionCounter < 8; directionCounter++)
            {
                if (this.vertical[directionCounter] == directionVertical
                    && this.horizontal[directionCounter] == directionHorizontal)
                {
                    return directionCounter;
                }
            }

            throw new ArgumentException("Missing direction!");
        }

        public void ChangeDirection(ref int directionVertical, ref int directionHorizontal)
        {
            int currentDirectionIndex = this.FindDirection(directionVertical, directionHorizontal);

            if (currentDirectionIndex == 7)
            {
                directionVertical = this.vertical[0];
                directionHorizontal = this.horizontal[0];
            }
            else
            {
                directionVertical = this.vertical[currentDirectionIndex + 1];
                directionHorizontal = this.horizontal[currentDirectionIndex + 1];
            }
        }

        public bool CheckPossibleDirection(int[,] matrix, int vertical, int horizontal)
        {
            int[] possibleDirectionVertical = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] possibleDirectionHorizontal = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int index = 0; index < 8; index++)
            {
                if (vertical + possibleDirectionVertical[index] >= matrix.GetLength(0) || vertical + possibleDirectionVertical[index] < 0)
                {
                    possibleDirectionVertical[index] = 0;
                }

                if (horizontal + possibleDirectionHorizontal[index] >= matrix.GetLength(0) || horizontal + possibleDirectionHorizontal[index] < 0)
                {
                    possibleDirectionHorizontal[index] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[vertical + possibleDirectionVertical[i], horizontal + possibleDirectionHorizontal[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsOutOfMatrix(int vertical, int horizontal, int directionRow, int directionCol, int matrixSize)
        {
            if (vertical + directionCol >= matrixSize
                                      || vertical + directionCol < 0
                                      || horizontal + directionRow >= matrixSize
                                      || horizontal + directionRow < 0
                                      || this.MatrixToPrint[vertical + directionCol, horizontal + directionRow] != 0)
            {
                return true;
            }

            return false;
        }
    }
}
