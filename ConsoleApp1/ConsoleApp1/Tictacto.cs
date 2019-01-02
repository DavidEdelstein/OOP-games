using System;

namespace TICTACTOE
{
    class Tictacto : IGameboard
    {
        public Tictacto()
        {
            string[] Line1 = new string [3] { "x","o","x"};
            string[] Line2 = new string [3] { "o","x","o" };
            string[] Line3 = new string [3] { "x","o","x" };
            GameBoard = new string[3][] { Line1, Line2, Line3 };
        }

        public string[][] GameBoard { get; set; }

        //LOOKS AT THE BOARD AND RETURN TRUE IF THERES A WINNER AND FALSE IF NO WINNER
        public bool GameIsWonRows()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                var row = GameBoard[i];
                if (GameBoard[i][0] == GameBoard[i][1] && GameBoard[i][2] == GameBoard[i][1])
                //if (row[0] == row[1] && row[2] == row[1])
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
            for (int i = 0; i < GameBoard.Length; i++)
            {
                if (GameBoard[0][i] == GameBoard[1][i] && GameBoard[2][i] == GameBoard[1][i])
                {
                    Console.WriteLine("The game is won!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("This is not a win!!");
                }
            }
            return false;
        }
        public bool GameIsWonDiagonal()
        {
            if (GameBoard[0][0]==GameBoard[1][1] && GameBoard[1][1]==GameBoard[2][2])
            {
                Console.WriteLine("This game is a win!!!!!!!!!!!!!!");
                return true;
            }
            else if (GameBoard[0][2]==GameBoard[1][1] && GameBoard[1][1]==GameBoard[2][0])
            {
                Console.WriteLine("This game is a win!!!!!!!!!!");
                return true;
            }
            else
            {
                Console.WriteLine("This game is not win :(");
            }
            return false;
        }

        public bool GameIsWon()
        {
            var RowHasAWin = GameIsWonRows();
            var ColumnHasAWin = GameIsWonColumns();
            var DiagonalHasAWin = GameIsWonDiagonal();

            if (RowHasAWin == true)
            {
                return true;
            }
            else if (ColumnHasAWin == true)
            {
                return true;
            }
            else if (DiagonalHasAWin == true)
            {
                return true;
            }
            else
            {
                return false;
            }

            return GameIsWonRows() || GameIsWonColumns() || GameIsWonDiagonal();
        }
    }
}
