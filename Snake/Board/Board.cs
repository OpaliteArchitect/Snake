namespace Snake.Board
{
    public record struct Position(int row, int col);
    internal class Board
    {
        public Cell[,] grid;
        public int row, col;
        public Food food;
        public Snake snake;

        readonly Random rnd = new();

        public Board(int row = 10, int col = 10)
        {
            grid = new Cell[row, col];
            this.row = row;
            this.col = col;
            SpawnSnake();
            SpawnFood();
        }

        private void SpawnSnake()
        {
            LinkedList<Position> body = [];
            string direction;

            //row & column index 3 to r/c - 4 to spawn snake inside
            int r = rnd.Next(3, row - 4);
            int c = rnd.Next(3, col - 4);
            body.AddLast(new Position(r, c));

            int[] rBody = { r, r };
            int[] cBody = { c, c };

            switch (rnd.Next(4))
            {
                case 0:
                    direction = "W";
                    rBody[0] = r + 1;
                    rBody[1] = r + 2;
                    break;
                case 1:
                    direction = "A";
                    cBody[0] = c + 1;
                    cBody[1] = c + 2;
                    break;
                case 2:
                    direction = "S";
                    rBody[0] = r - 1;
                    rBody[1] = r - 2;
                    break;
                case 3:
                    direction = "D";
                    cBody[0] = c - 1;
                    cBody[1] = c - 2;
                    break;
                default: throw new Exception("Not really possible");
            }

            body.AddLast(new Position(rBody[0], cBody[0]));
            body.AddLast(new Position(rBody[1], cBody[1]));

            snake = new(body, direction);
        }

        public void SpawnFood()
        {
            Position foodPos;
            bool invalidSpawn;

            do
            {
                foodPos = new(rnd.Next(row), rnd.Next(col));
            } while (snake.GetSnakeBodyPositions().Any(bodyPos => foodPos == bodyPos));

            food = new(foodPos);
        }
    }
}
