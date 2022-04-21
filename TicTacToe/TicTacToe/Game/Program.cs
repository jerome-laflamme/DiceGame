using System;
using TicTacToeClass;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Want to play Tic Tac Toe ? (Y/N)  ");
                int playInput = Char.Parse(Console.ReadLine());
                if (playInput == 'N') Environment.Exit(0);
                
                Space[] space = new Space[9];
                Board.PrintBoard();
            }
        }
    }
}