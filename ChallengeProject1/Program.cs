using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tic Tac Toe (2 Players) ===");

            Player p1 = new Player(AskName("Player 1 (X)", "Player 1"), 'X');
            Player p2 = new Player(AskName("Player 2 (O)", "Player 2"), 'O');

            var game = new Game(p1, p2);
            Player starter = p1;

            do
            {
                game.PlayRound(starter);
                game.ShowScore();

                // Alternate who goes first each round
                starter = (starter == p1) ? p2 : p1;

                Console.Write("Play again? (y/n): ");
            }
            while (Console.ReadLine()?.Trim().ToLower() == "y");

            Console.WriteLine("Thanks for playing!");
        }

        static string AskName(string label, string fallback)
        {
            Console.Write($"Enter name for {label}: ");
            string name = Console.ReadLine();
            return string.IsNullOrWhiteSpace(name) ? fallback : name.Trim();
        }
    }
}
