using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    class Player
    {
        const int GRID_SIZE = 10;

        List<List<SeaSquare>> _myGrid = new List<List<SeaSquare>>();
        public List<List<SeaSquare>> MyGrid { get { return _myGrid; } }

        List<List<SeaSquare>> enemyGrid = new List<List<SeaSquare>>();

        public Player()
        {
            for (int i = 0; i != GRID_SIZE; ++i)
            {
                _myGrid.Add(new List<SeaSquare>());
                for (int j = 0; j != GRID_SIZE; ++j)
                    _myGrid[i].Add(new SeaSquare(i, j));
            }
        }
    }
}
