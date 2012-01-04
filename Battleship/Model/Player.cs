using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    class Player
    {
        const int GRID_SIZE = 10;

        List<List<SquareType>> _myGrid = new List<List<SquareType>>();
        public List<List<SquareType>> MyGrid { get { return _myGrid; } }
        
        List<List<SquareType>> enemyGrid = new List<List<SquareType>>();

        public Player()
        {
            for (int i = 0; i != GRID_SIZE; ++i)
            {
                _myGrid.Add(new List<SquareType>());
                for (int j = 0; j != GRID_SIZE; ++j)
                    _myGrid[i].Add(new SquareType());
            }
        }
    }
}
