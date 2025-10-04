namespace Snake.Board
{
    internal class ScoreChangedEventArgs(int score) : EventArgs
    {
        public int score = score;
    }
}
