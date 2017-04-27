namespace RotatingWalkInMatrix
{
    using GameFifteen;
    using GameFifteen.Models;
    using System;

    public class Startup
    {
        public static void Main()
        {
            const string ENTER_POSITIVE_INT_MSG = "Please, enter a positive integer: ";
            const string INCORRECT_INPUT_MSG = "Your input is invalid. Enter a positive integer: ";
            const int MIN_SIZE_OF_MATRIX = 0;
            const int MAX_SIZE_OF_MATRIX = 30;

            var logger = new Logger();
            logger.Write(ENTER_POSITIVE_INT_MSG);

            int matrixSize = int.Parse(Console.ReadLine());

            if (matrixSize < MIN_SIZE_OF_MATRIX || matrixSize > MAX_SIZE_OF_MATRIX)
            {
                logger.Write(INCORRECT_INPUT_MSG);
                matrixSize = int.Parse(Console.ReadLine());
            }

            var engine = new Engine(matrixSize);
            engine.GenerateMatrix();
        }
    }
}