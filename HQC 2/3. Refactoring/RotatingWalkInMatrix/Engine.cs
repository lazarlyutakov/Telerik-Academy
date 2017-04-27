using GameFifteen.Models;

namespace GameFifteen
{
    public class Engine
    {
        private int matrixSize;

        public Engine(int matrixSize)
        {
            this.MatrixSize = matrixSize;
        }

        public int MatrixSize { get; set; }

        public void GenerateMatrix()
        {
            var matrix = new Matrix(this.MatrixSize);

            int vertical = 0;
            int horizontal = 0;

            matrix.FillUpTheMatrix(vertical, horizontal, this.MatrixSize);

            matrix.FindFreeCell(out vertical, out horizontal);

            if (vertical != 0 && horizontal != 0)
            {
                matrix.FillUpTheMatrix(vertical, horizontal, this.MatrixSize);
            }

            matrix.PrintMatrix();
        }           
    }
}
