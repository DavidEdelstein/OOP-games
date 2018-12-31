using System;

namespace TICTACTOE
{
    class Tictacto : IGameboard
    {
        public Tictacto()
        {
            string[] Line1 = new string [3] { "x","o","x"};
            string[] Line2 = new string [3] { "x","x","x" };
            string[] Line3 = new string [3] { "o","x","o" };
            GameBoard = new string[3][] { Line1, Line2, Line3 };
        }

        public string[][] GameBoard { get; set; }

        //LOOKS AT THE BOARD AND RETURN TRUE IF THERES A WINNER AND FALSE IF NO WINNER
        public bool GameIsWonRows()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                var row = GameBoard[i];
                if (row[0] == row[1] && row[2] == row[0])
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
           
        }
        public bool GameIsWonColumns()
        {
            for (int i = 0; i < GameBoard.Rank; i++)
            {

            }
            return false;
        }
    }
}
