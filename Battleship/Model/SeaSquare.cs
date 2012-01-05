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
        public int Row { get; private set;  }
        public int Col { get; private set; }

        public SeaSquare(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
