using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var g = new Tictacto();
        }
    }



    class Tictacto : IGameboard
    {
        public Tictacto()
        {
            bool[] Line1 = new bool [3] { true, false, true };
            bool[] Line2 = new bool [3] { true, false, true };
            bool[] Line3 = new bool [3] { true, false, true };
            GameBoard = new bool[3][] { Line1, Line2, Line3 };
        }

        public bool[][] GameBoard { get; set; }

        //LOOK AT THE BOARD AND RETURN TRUE IF THERES A WINNER AND FALSE IF NO WINNER
        public bool GameIsWon()
        {
            if (Line1[0] == true && Line2[0]== true && Line3[0]==true)
            {
                Console.WriteLine("The game is won!");
            }
        }
    }

    interface IGameboard
    {
        bool GameIsWon();
    }
}
