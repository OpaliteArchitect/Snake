using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Board
{
    internal class NextHeadEventArgs(Position snakeBody) : EventArgs
    {
        public Position snakeBody = snakeBody;
    }
}
