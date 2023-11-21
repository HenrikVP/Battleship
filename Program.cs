namespace Battleship
{
    internal class Program
    {
        enum Piece { Pawn, Rook, Knight, Bishop, Queen, King }
        enum ChessColor { Black, White }

        static void Main(string[] args)
        {
            ChatGPT.Game();

            Console.WriteLine("Hello, World!");

            // Skak 
            //2 arrays af 16 arrays af 3 værdier
            //                     {c, {p, {x, y, T}}}
            int[,,] array2 = new int[2, 16, 3];

            //32 arrays af 4 værdier
            //                      p {x,y,T,c}
            int[,] array = new int[32, 4];

            Console.WriteLine(
                $"Piece {(Piece)array[0, 2]} " +
                $"Color {(ChessColor)array[0, 3]} " +
                $"Pos (x,y) {array[0, 0]}, {array[0, 1]}");


            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine(numbers[1, j]);
            }

            //   2 players with each 17 spots with 2 coordinates P,#,{x,y}
                        //Player, Shippart, X,Y
            int[,,] ships = new int[2, 3, 2];
            int[,,] ships3 = new int[2, 3, 2];

            int[,,] shipsP1 = { { { 1, 2 }, { 4, 5 }, { 7, 3 } }, { { 1, 2 }, { 4, 5 }, { 7, 3 } } };

            //int[,,] ships = { { { { 3,5 } },{ },{ } }, { } };
            ships[0, 0, 0] = 3;
            ships[0, 0, 1] = 5;

            ships[0, 1, 0] = 3;
            ships[0, 1, 1] = 6;


            int[,] p1Ships = new int[17, 2];
            int[,] p2Ships = new int[17, 2];
            int[,] p1Shots = new int[100, 2];
            int[,] p2Shots = new int[100, 2];

            int[,,] ships2 = new int[2, 17, 2];

            ships2[0, 0, 0] = 4;
            ships2[0, 0, 1] = 8;

            //ships2[]

            //                     P, { x,y,T}
            int[,] hits = new int[2, 3];
                                //player, hit/ship, {x,y}
            int[,,] all = new int[2, 2, 2];

            //Board 10x10
            //5 skibe, 17 felter (patrolboat2, submarine3, destroyer3, battleship4, carrier5)
            //Player 1 sets a ship at 3,5

            //Kryds og bolle
            //int[,] kogb = new[];
        }
        enum Battleship { Empty, Hit, P}
    }
}