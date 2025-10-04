using Snake.UI;
using System.Threading.Tasks;

namespace Snake.Board
{
    internal class GameState
    {
        public Board board = new(25, 25);
        public int speed = 250;
        private readonly int slopeChange = 150;
        private int score = 0;
        public int Score
        {
            get => score;
            set
            {
                score = value;
                ScoreChanged?.Invoke(this, new(score));
            }
        }
        public event EventHandler<SnakeDeathEventArgs> SnakeDied;
        public event EventHandler<ScoreChangedEventArgs> ScoreChanged;

        private string nextDirection;
        private readonly Dictionary<string, string> oppositeDirections = new()
        {
            {"W","S" },
            {"A","D" },
            {"S","W" },
            {"D","A" }
        };

        public GameState()
        {

        }

        public void Start()
        {
            GameLoop();
        }

        public async Task GameLoop()
        {
            for (; ; )
            {
                ChangeDirection();

                Position nextHead = board.snake.NextHead();

                if (WillCollide(nextHead))
                {
                    SnakeDied?.Invoke(this, new(Score));
                    break;
                }

                else
                {
                    bool ate = WillEat(nextHead);
                    board.snake.Move(nextHead, ate);
                    if (ate)
                    {
                        board.SpawnFood();
                        Score += 10;
                        //piecewise function, for every food eaten, reduces tick by 10 until 150, at which point it reduces by 5
                        //fastest tick is reached at 300 points
                        speed = 250 - (Score < slopeChange ? Score : (slopeChange + Score) / 2); // (SC + (score - SC) / 2) = ((SC + score) / 2)
                    }
                }

                await Task.Delay(Math.Max(speed, 25));
            }
        }

        private bool WillEat(Position nextHead) => nextHead == board.food.position;

        private bool WillCollide(Position nextHead)
        {
            //wall collision
            if (nextHead.row < 0 || nextHead.row >= board.row || nextHead.col < 0 || nextHead.col >= board.col) return true;

            //body collision
            foreach (var pos in board.snake.GetSnakeBodyPositions())
            {
                if (nextHead == pos) return true;
            }

            return false;
        }

        private void ChangeDirection()
        {
            board.snake.Direction = nextDirection ?? board.snake.Direction;
        }

        public bool NextDirection(string direction)
        {
            if (!"WASD".Contains(direction) || oppositeDirections[direction] == board.snake.Direction)
            {
                return false;
            }
            nextDirection = direction;
            return true;
        }
    }
}
