using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    enum SquareType { Unknown, Water, Undamaged, Damaged, Sunk }

    class SeaSquare
    {
        public SquareType Type {get; set;}
        public int X { get; set; }
        public int Y { get; set; }

        public SeaSquare(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
