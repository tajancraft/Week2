namespace TicTacToe
{
    public class Player
    {
        public string Name { get; }
        public char Mark { get; }
        public int Wins { get; set; }

        public Player(string name, char mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
