using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    class HumanPlayer: Player
    {
        public void TakeTurn(int row, int col, Player otherPlayer)
        {
            Fire(row, col, otherPlayer);
        }
    }
}
