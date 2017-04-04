using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Engine
    {
        private const string Rules = @"
                              Try to open all the fields without stepping over a mine.
                                                  
                                                      Commands:

                                              'top' - displays the Highscore
                                               'restart' - starts a new game
                                                 'exit'- ends the game";

        private const int MAX_POSSIBLE_MOVES = 35;
        private const int GAME_FIELD_ROWS = 5;
        private const int GAME_FIELD_COLS = 10;

        private const char MINE_SYMBOL = '*';
        private const char NO_MINE_SYMBOL = '-';
        private const char NOT_VISITTED_FIELD = '?';

        private static readonly string YouWon = $"Bravo! You succeed to open all {MAX_POSSIBLE_MOVES} fields";

        public static void Run()
        {
            string command = string.Empty;
            char[,] gameField = GenerateGameField();
            char[,] mines = GenerateMines();
            int pointsCounter = 0;
            bool isMineExploded = false;
            List<Score> hignScoreInfo = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool isGameOver = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(Rules);
                    PrintGameField(gameField);
                    isNewGame = false;
                }

                Console.WriteLine("Enter row and column!");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighScoreList(hignScoreInfo);
                        break;
                    case "restart":
                        gameField = GenerateGameField();
                        mines = GenerateMines();
                        PrintGameField(gameField);
                        isMineExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != MINE_SYMBOL)
                        {
                            if (mines[row, col] == NO_MINE_SYMBOL)
                            {
                                ShowFieldValue(gameField, mines, row, col);
                                pointsCounter++;
                            }

                            if (MAX_POSSIBLE_MOVES == pointsCounter)
                            {
                                isGameOver = true;
                            }
                            else
                            {
                                PrintGameField(gameField);
                            }
                        }
                        else
                        {
                            isMineExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Wrong Command!");
                        break;
                }

                if (isMineExploded)
                {
                    PrintGameField(mines);
                    Console.Write(string.Format("You lost : {0} points!", pointsCounter));
                    Console.WriteLine("Enter nickname!");

                    string nickname = Console.ReadLine();
                    Score currentPlayer = new Score(nickname, pointsCounter);

                    if (hignScoreInfo.Count < 6 - 1)
                    {
                        hignScoreInfo.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < hignScoreInfo.Count; i++)
                        {
                            if (hignScoreInfo[i].Points < currentPlayer.Points)
                            {
                                hignScoreInfo.Insert(i, currentPlayer);
                                hignScoreInfo.RemoveAt(hignScoreInfo.Count - 1);
                                break;
                            }
                        }
                    }

                    hignScoreInfo.Sort((Score firstPlayerInfo, Score nextPlayerInfo) =>
                    nextPlayerInfo.Name.CompareTo(firstPlayerInfo.Name));
                    hignScoreInfo.Sort((Score firstPlayerInfo, Score nextPlayerInfo) =>
                    nextPlayerInfo.Points.CompareTo(firstPlayerInfo.Points));
                    ShowHighScoreList(hignScoreInfo);

                    gameField = GenerateGameField();
                    mines = GenerateMines();
                    pointsCounter = 0;
                    isMineExploded = false;
                    isNewGame = true;
                }

                if (isGameOver)
                {
                    Console.WriteLine(YouWon);
                    PrintGameField(mines);
                    Console.WriteLine("Enter nickname!");
                    string nickname = Console.ReadLine();
                    Score currentPlayerInfo = new Score(nickname, pointsCounter);
                    hignScoreInfo.Add(currentPlayerInfo);
                    ShowHighScoreList(hignScoreInfo);
                    gameField = GenerateGameField();
                    mines = GenerateMines();
                    pointsCounter = 0;
                    isGameOver = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.Read();
        }

        private static void ShowHighScoreList(List<Score> highScoreInfo)
        {
            Console.WriteLine("Top players : ");

            if (highScoreInfo.Count > 0)
            {
                for (int i = 0; i < highScoreInfo.Count; i++)
                {
                    Console.WriteLine($"{i}. {highScoreInfo[i].Name} --> {highScoreInfo[i].Points}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No high scores available");
            }
        }

        private static void ShowFieldValue(char[,] gameField, char[,] mines, int row, int col)
        {
            char minesCount = CountMines(mines, row, col);
            mines[row, col] = minesCount;
            gameField[row, col] = minesCount;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(string.Format("{0}", gameField[i, j]));
                }

                Console.WriteLine("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateGameField()
        {
            char[,] board = new char[GAME_FIELD_ROWS, GAME_FIELD_COLS];

            for (int i = 0; i < GAME_FIELD_ROWS; i++)
            {
                for (int j = 0; j < GAME_FIELD_COLS; j++)
                {
                    board[i, j] = NOT_VISITTED_FIELD;
                }
            }
            return board;
        }

        private static char[,] GenerateMines()
        {
            char[,] gameField = new char[GAME_FIELD_ROWS, GAME_FIELD_COLS];

            for (int i = 0; i < GAME_FIELD_ROWS; i++)
            {
                for (int j = 0; j < GAME_FIELD_COLS; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / GAME_FIELD_COLS;
                int row = mine % GAME_FIELD_COLS;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = GAME_FIELD_COLS;
                }
                else
                {
                    row++;
                }
                gameField[col, row - 1] = MINE_SYMBOL;
            }
            return gameField;
        }

        private static void GetNeighbourMinesCount(char[,] gameField)
        {
            int cols = gameField.GetLength(0);
            int rows = gameField.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (gameField[i, j] != MINE_SYMBOL)
                    {
                        char minesAroundCoveredCell = CountMines(gameField, i, j);
                        gameField[i, j] = minesAroundCoveredCell;
                    }
                }
            }
        }

        private static char CountMines(char[,] gameField, int row, int col)
        {
            int minesNumber = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == MINE_SYMBOL)
                {
                    minesNumber--;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == MINE_SYMBOL)
                {
                    minesNumber++;
                }
            }

            return char.Parse(minesNumber.ToString());
        }
    }

}




