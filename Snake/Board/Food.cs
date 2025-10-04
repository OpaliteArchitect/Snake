namespace Snake.Board
{
    internal class Food(Position position)
    {
        public Position position = position;

        public Food(int row, int col) : this(new(row, col)) { }
    }
}
