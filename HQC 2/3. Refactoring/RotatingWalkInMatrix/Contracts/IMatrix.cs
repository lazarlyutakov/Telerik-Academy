namespace GameFifteen.Contracts
{
    public interface IMatrix
    {
        int MatrixSize { get; set; }

        int[,] MatrixToPrint { get; set; }

        int AmountOfNumbers { get; set; }

        void FindFreeCell(out int vertical, out int horizontal);

        void FillUpTheMatrix(int vertical, int horizontal, int matrixSize);

        int FindDirection(int directionVertical, int directionHorizontal);

        void ChangeDirection(ref int directionVertical, ref int directionHorizontal);

        bool CheckPossibleDirection(int[,] matrix, int vertical, int horizontal);

        bool IsOutOfMatrix(int vertical, int horizontal, int directionRow, int directionCol, int dimension);

        void PrintMatrix();
    }
}