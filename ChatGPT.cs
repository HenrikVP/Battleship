namespace Battleship
{
    class ChatGPT
    {
        static int boardSize = 10;
        static char[,] playerBoard = new char[boardSize, boardSize];
        static char[,] enemyBoard = new char[boardSize, boardSize];
        static int numberOfShips = 5;

        public static void Game()
        {
            InitializeBoards();
            PlaceShips();

            Console.WriteLine("Welcome to Battleship Game!");

            do
            {
                Console.WriteLine("\nPlayer Board:");
                DisplayBoard(playerBoard);

                Console.WriteLine("\nEnemy Board:");
                DisplayBoard(enemyBoard);

                Console.WriteLine("\nEnter coordinates to fire (e.g., A3):");
                string input = Console.ReadLine().ToUpper();

                if (input.Length == 2 && char.IsLetter(input[0]) && char.IsDigit(input[1]))
                {
                    int row = input[0] - 'A';
                    int col = input[1] - '0';

                    if (row >= 0 && row < boardSize && col >= 0 && col < boardSize)
                    {
                        if (enemyBoard[row, col] == 'S')
                        {
                            Console.WriteLine("Hit!");
                            enemyBoard[row, col] = 'X';
                            numberOfShips--;

                            if (numberOfShips == 0)
                            {
                                Console.WriteLine("Congratulations! You sunk all enemy ships.");
                                break;
                            }
                        }
                        else if (enemyBoard[row, col] == 'X')
                        {
                            Console.WriteLine("You already fired at this location. Try again.");
                        }
                        else
                        {
                            Console.WriteLine("Miss!");
                            enemyBoard[row, col] = 'O';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter coordinates in the format A3.");
                }

            } while (numberOfShips > 0);

            Console.WriteLine("Game Over. Thanks for playing!");
        }

        static void InitializeBoards()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    playerBoard[i, j] = '-';
                    enemyBoard[i, j] = '-';
                }
            }
        }

        static void DisplayBoard(char[,] board)
        {
            Console.Write("  ");
            for (int i = 0; i < boardSize; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < boardSize; i++)
            {
                Console.Write((char)('A' + i) + " ");
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PlaceShips()
        {
            Random random = new Random();

            for (int i = 0; i < numberOfShips; i++)
            {
                int row, col;

                do
                {
                    row = random.Next(0, boardSize);
                    col = random.Next(0, boardSize);
                } while (enemyBoard[row, col] == 'S');

                enemyBoard[row, col] = 'S';
            }
        }
    }
}
