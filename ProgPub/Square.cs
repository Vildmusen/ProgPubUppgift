using System;
using System.Collections.Generic;

namespace ProgPub
{
    class Square
    {
        public bool isAlive { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public event EventHandler<SquareEventArgs> Changed;

        public Square(int x, int y)
        {
            isAlive = true;
            this.x = x;
            this.y = y;
        }

        public void Subscribe(List<Square> squares)
        {
            foreach(Square s in squares)
            {
                if(s != this)
                {
                    s.Changed += onChange;
                }
            }
        }

        public void onClick()
        {
            isAlive = !isAlive;
            SquareEventArgs args = new SquareEventArgs(x, y);
            Changed?.Invoke(this, args);
        }

        public void onChange(object sender, SquareEventArgs e)
        {
            if(e.Y == y && (e.X == x - 1 || e.X == x + 1))
            {
                isAlive = !isAlive;
            }
            if (e.X == x && (e.Y == y - 1 || e.Y == y + 1))
            {
                isAlive = !isAlive;
            }
        }
    }
}
