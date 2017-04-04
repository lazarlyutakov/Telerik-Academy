using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T>
    {
        private T[,] matrix;


        public Matrix(int row, int col)
        {
            matrix = new T[row, col];
        }


        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return matrix.GetLength(1); }
        }


        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    matrix[row, col] = value;
                }

            }
        }


        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols)
            {
                Matrix<T> sum = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        sum[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }

                return sum;
            }

            else
            {
                throw new ArgumentException("Matrices not equal !");
            }
        }


        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols)
            {
                Matrix<T> difference = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        difference[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }

                return difference;
            }

            else
            {
                throw new ArgumentException("Matrices not equal !");
            }
        }


        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("Operation impossible - Rows must equal Cols !");
            }
            else
            {
                Matrix<T> product = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

                for (int i = 0; i < product.Rows; i++)
                {
                    for (int j = 0; j < product.Cols; j++)
                    {
                        for (int k = 0; k < firstMatrix.Cols; k++)
                        {
                            product[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }
                return product;
            }


        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool differsZero = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        differsZero = false;
                    }
                }
            }

            return differsZero;
        }


        public static bool operator false(Matrix<T> matrix)
        {
            bool differsZero = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        differsZero = false;
                    }
                }
            }

            return differsZero;
        }

    }
}
