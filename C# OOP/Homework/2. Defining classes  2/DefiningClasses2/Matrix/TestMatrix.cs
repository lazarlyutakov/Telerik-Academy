using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class TestMatrix
    {

        static void Main()
        {


            Matrix<int> firstMatrix = new Matrix<int>(4, 4);
        Matrix<int> secondMatrix = new Matrix<int>(4, 4);

        for (int i = 0; i < firstMatrix.Rows; i++)
			{
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = i + j + 1;
                }
			}

            for (int i = 0; i < secondMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    secondMatrix[i, j] = i + j + 2;
                }
            }

            Matrix<int> sum = firstMatrix + secondMatrix;
            Matrix<int> difference = firstMatrix - secondMatrix;
            Matrix<int> product = firstMatrix * secondMatrix;

            for (int i = 0; i < product.Rows; i++)
            {
                for (int j = 0; j < product.Cols; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
}
}
