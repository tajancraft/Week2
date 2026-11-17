using System;

namespace TicTacToe
{
    public class Board
    {
        private readonly char[] _cells = new char[9];

        private static readonly int[][] WinLines =
        {
            new[] { 0, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 }, // rows
            new[] { 0, 3, 6 }, new[] { 1, 4, 7 }, new[] { 2, 5, 8 }, // columns
            new[] { 0, 4, 8 }, new[] { 2, 4, 6 }                     // diagonals
        };

        public Board()
        {
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < _cells.Length; i++)
                _cells[i] = ' ';
        }

        // position is 1-9
        public bool IsCellFree(int position)
        {
            return position >= 1 && position <= 9 && _cells[position - 1] == ' ';
        }

        public bool Place(int position, char mark)
        {
            if (!IsCellFree(position))
                return false;

            _cells[position - 1] = mark;
            return true;
        }

        public bool HasWon(char mark)
        {
            foreach (int[] line in WinLines)
            {
                if (_cells[line[0]] == mark &&
                    _cells[line[1]] == mark &&
                    _cells[line[2]] == mark)
                    return true;
            }
            return false;
        }

        public bool IsFull()
        {
            foreach (char c in _cells)
            {
                if (c == ' ')
                    return false;
            }
            return true;
        }

        public void Display()
        {
            Console.WriteLine();
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine($" {Show(row * 3)} | {Show(row * 3 + 1)} | {Show(row * 3 + 2)} ");
                if (row < 2)
                    Console.WriteLine("---+---+---");
            }
            Console.WriteLine();
        }

        // Empty cells show their number so players know what to type
        private char Show(int index)
        {
            return _cells[index] == ' ' ? (char)('1' + index) : _cells[index];
        }
    }
}
