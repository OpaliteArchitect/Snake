namespace Snake.Board
{
    internal class SnakeDeathEventArgs(int score) : EventArgs
    {
        public int score = score;
    }
}
