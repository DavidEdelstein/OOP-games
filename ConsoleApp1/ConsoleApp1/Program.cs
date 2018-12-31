using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var g = new Tictacto();
            g.GameIsWonRows();

            Console.ReadKey();
        }
    }
}
