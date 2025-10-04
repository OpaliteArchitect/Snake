using System.CodeDom;

namespace Snake.Board
{
    internal class Snake
    {
        public LinkedList<Position> BodyParts { get; set; } = [];
        public Position Head => BodyParts.First.Value;
        public string Direction { get; set; }
        public event EventHandler SnakeMoved;

        public Snake(LinkedList<Position> bodyParts, string direction)
        {
            BodyParts = bodyParts;
            Direction = direction;
        }

        public Position NextHead()
        {
            Position nextHead = Direction switch
            {
                "W" => new(Head.row - 1, Head.col),
                "A" => new(Head.row, Head.col - 1),
                "S" => new(Head.row + 1, Head.col),
                "D" => new(Head.row, Head.col + 1),
                _ => throw new ArgumentException("Not WASD")
            };

            return nextHead;
        }

        public void Move(Position nextHead, bool ateFood)
        {
            BodyParts.AddFirst(nextHead);
            if (!ateFood)
            {
                BodyParts.RemoveLast();
            }

            SnakeMoved?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerMove()
        {
            SnakeMoved?.Invoke(this, EventArgs.Empty);
        }

        public IEnumerable<Position> GetSnakeBodyPositions()
        {
            for (LinkedListNode<Position> node = BodyParts.First; node != null; node = node.Next)
            {
                yield return node.Value;
            }
        }
    }
}
