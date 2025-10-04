using Snake.Board;

namespace Snake.UI
{
    public partial class Board_UC : UserControl
    {
        GameState gameState;
        int boardRows;
        int boardColumns;
        Rectangle cellRect;
        int tongueOut;

        readonly Random rnd = new();

        public Board_UC()
        {
            gameState = new();
            boardRows = gameState.board.row;
            boardColumns = gameState.board.col;

            InitializeSubscriptions();
            InitializeComponent();
        }

        private void OnSnakeDied(object? sender, SnakeDeathEventArgs e)
        {
            Form form = FindForm();
            GameOver gameOver_UC = new(e.score, this);
            form.Controls.Add(gameOver_UC);
            gameOver_UC.Location = new(
                (form.ClientSize.Width - gameOver_UC.Width) / 2,
                (form.ClientSize.Height - gameOver_UC.Height) / 2
                );
            gameOver_UC.BringToFront();
        }

        private void Board_UC_Load(object sender, EventArgs e)
        {
            Focus();
            //SetStyle(ControlStyles.Selectable, true);
            gameState.Start();
        }

        private void InitializeSubscriptions()
        {
            gameState.board.snake.SnakeMoved += OnSnakeMoved;
            gameState.ScoreChanged += OnScoreChanged;
            gameState.SnakeDied += OnSnakeDied;
        }

        private void board_Panel_Paint(object sender, PaintEventArgs e)
        {
            int height = board_Panel.Height / boardRows;
            int width = board_Panel.Width / boardColumns;

            Graphics g = e.Graphics;

            for (int r = 0; r < boardRows; r++)
            {
                for (int c = 0; c < boardColumns; c++)
                {
                    cellRect = new Rectangle(c * width, r * height, width, height);

                    g.FillRectangle(new SolidBrush(Color.White), cellRect);
                    g.DrawRectangle(new Pen(Color.Black), cellRect);
                }
            }

            DrawBackground(width, height, g);
            DrawSnakeAndFood(width, height, g);
        }

        private void DrawBackground(int width, int height, Graphics g)
        {
            for (int r = 0; r < boardRows; r++)
            {
                for (int c = 0; c < boardColumns; c++)
                {
                    cellRect = new Rectangle(c * width, r * height, width, height);

                    g.FillRectangle(new SolidBrush(Color.Black), cellRect);
                }
            }
        }

        private void DrawSnakeAndFood(int width, int height, Graphics g)
        {
            string facing = gameState.board.snake.Direction;

            //snake
            foreach (var pos in gameState.board.snake.GetSnakeBodyPositions())
            {
                cellRect = new Rectangle(pos.col * width, pos.row * height, width, height);

                g.FillRectangle(new SolidBrush(Color.White), cellRect);
                g.DrawRectangle(new Pen(Color.Black), cellRect);
                //eyes
                if (pos == gameState.board.snake.Head)
                {
                    int gap = width / 4;
                    (int, int)[] eyePos = [
                        (pos.col * width + gap, pos.row * height + gap),                //Upper Left
                        ((pos.col + 1) * width - gap, pos.row * height + gap),          //Upper Right
                        (pos.col * width + gap, (pos.row + 1) * height - gap),          //Lower Left
                        ((pos.col + 1) * width - gap, (pos.row + 1) * height - gap)     //Lower Right
                    ];

                    ((int, int), (int, int)) eyes = facing switch
                    {
                        "W" => (eyePos[0], eyePos[1]),
                        "A" => (eyePos[0], eyePos[2]),
                        "S" => (eyePos[2], eyePos[3]),
                        "D" => (eyePos[1], eyePos[3]),
                        _ => throw new Exception("Invalid direction")
                    };

                    int eyeWidth = width / 5; 
                    int eyeHeight = height / 5;

                    cellRect = new Rectangle(eyes.Item1.Item1 - (eyeWidth / 2), eyes.Item1.Item2 - (eyeWidth / 2), eyeWidth, eyeHeight);
                    g.FillRectangle(new SolidBrush(Color.Black), cellRect);

                    cellRect = new Rectangle(eyes.Item2.Item1 - (eyeWidth / 2), eyes.Item2.Item2 - (eyeWidth / 2), eyeWidth, eyeHeight);
                    g.FillRectangle(new SolidBrush(Color.Black), cellRect);
                }
            }

            //food

            Position foodPos = gameState.board.food.position;

            cellRect = new Rectangle(foodPos.col * width, foodPos.row * height, width, height);

            g.FillRectangle(new SolidBrush(Color.Yellow), cellRect);
            g.DrawRectangle(new Pen(Color.Black), cellRect);

            //tongue
            if (tongueOut == 0)
            {
                if (rnd.Next(6) > 4)
                {
                    tongueOut = rnd.Next(1, 3);
                }
                return;
            }

            Position tongue = gameState.board.snake.NextHead();
            Rectangle[] tongues = [
                new(tongue.col * width + width * 3 / 8, tongue.row * height + height / 3, width / 4, height * 2 / 3), // W
                new(tongue.col * width  + width / 3, tongue.row * height + height * 3 / 8, width * 2 / 3, height / 4), // A
                new(tongue.col * width  + width * 3 / 8, tongue.row * height, width / 4, height * 2 / 3), // S
                new(tongue.col * width , tongue.row * height + height * 3 / 8, width * 2 / 3, height / 4), // D
            ];

            cellRect = facing switch
            {
                "W" => tongues[0],
                "A" => tongues[1],
                "S" => tongues[2],
                "D" => tongues[3],
                _ => throw new Exception("Invalid direction")
            };

            g.FillRectangle(new SolidBrush(Color.Red), cellRect);

            tongueOut--;
        }

        private void OnSnakeMoved(object? sender, EventArgs e)
        {
            board_Panel.Invalidate();
        }

        private void OnScoreChanged(object? sender, ScoreChangedEventArgs e)
        {
            //board_Panel.Invalidate();
            score_Label.Text = $"Score: {e.score}";
        }

        private void Board_UC_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            gameState.NextDirection(key);
        }
    }
}
