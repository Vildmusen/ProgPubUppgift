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
            // THIS IS CALLED FROM THE FORM WHEN WE CREATE A SQUARE
            // TODO IMPLEMENT SUBSCRIBE
        }

        public void onClick()
        {
            // THIS IS RUN WHEN USER PRESSES OUR BUTTON ON THE GRID
            // TODO IMPLEMENT ONCLICK
        }

        public void onChange(object sender, SquareEventArgs e)
        {
            // THIS SHOULD BE RUN ON EVENT
            // TODO IMPLEMENT ONCHANGE
        }
    }
}
