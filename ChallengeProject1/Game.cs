using System;

namespace TicTacToe
{
    public class Game
    {
        private readonly Board _board = new Board();
        private readonly Player _player1;
        private readonly Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void PlayRound(Player firstPlayer)
        {
            _board.Reset();
            Player current = firstPlayer;

            while (true)
            {
                _board.Display();
                int position = AskForMove(current);
                _board.Place(position, current.Mark);

                if (_board.HasWon(current.Mark))
                {
                    _board.Display();
                    Console.WriteLine($"{current.Name} ({current.Mark}) wins!");
                    current.Wins++;
                    return;
                }

                if (_board.IsFull())
                {
                    _board.Display();
                    Console.WriteLine("It's a draw!");
                    return;
                }

                current = (current == _player1) ? _player2 : _player1;
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Score - {_player1.Name}: {_player1.Wins} | {_player2.Name}: {_player2.Wins}");
        }

        private int AskForMove(Player player)
        {
            while (true)
            {
                Console.Write($"{player.Name} ({player.Mark}), choose a cell (1-9): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int position) || position < 1 || position > 9)
                {
                    Console.WriteLine("Please enter a number from 1 to 9.");
                    continue;
                }

                if (!_board.IsCellFree(position))
                {
                    Console.WriteLine("That cell is already taken. Try another.");
                    continue;
                }

                return position;
            }
        }
    }
}
