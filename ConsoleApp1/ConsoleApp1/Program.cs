using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var g = new Tictacto();
            g.GameIsWon();

            Console.ReadKey();
        }
    }



    class Tictacto : IGameboard
    {
        public Tictacto()
        {
            bool[] Line1 = new bool [3] { true, true, true };
            bool[] Line2 = new bool [3] { true, false, true };
            bool[] Line3 = new bool [3] { true, false, true };
            GameBoard = new bool[3][] { Line1, Line2, Line3 };
        }

        public bool[][] GameBoard { get; set; }

        //LOOK AT THE BOARD AND RETURN TRUE IF THERES A WINNER AND FALSE IF NO WINNER
        public bool GameIsWon()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                var row = GameBoard[i];
                if (row[0] == row[1] == row[2])
                {
                    Console.WriteLine("The game is won");
                    return true;
                }
                else
                {
                    Console.WriteLine("This is not a win");
                }
            }
            return false;
            //if (GameBoard[0][0] == true && GameBoard[0][1] == true && GameBoard[0][2] == true)
            //{
            //    Console.WriteLine("The game is won!");
            //    return true;
            //}
            //else
            //{
            //    Console.WriteLine("This is not a win");
            //}
            //return false;
        }
    }

    interface IGameboard
    {
        bool GameIsWon();
    }
}
