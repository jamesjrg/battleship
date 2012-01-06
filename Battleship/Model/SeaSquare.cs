using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Battleship.Model
{
    enum SquareType { Unknown, Water, Undamaged, Damaged, Sunk }

    class SeaSquare : DependencyObject
    {
        public int Row { get; private set;  }
        public int Col { get; private set; }
        public int ShipIndex { get; set; }

        public SquareType Type
        {
            get { return (SquareType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        public static readonly DependencyProperty TypeProperty =
        DependencyProperty.Register("Type", typeof(SquareType), typeof(SeaSquare), null);

        public SeaSquare(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public void Reset(SquareType type)
        {
            Type = type;
            ShipIndex = -1;
        }
    }
}
