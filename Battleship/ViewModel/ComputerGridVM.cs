using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship.Model;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace Battleship.ViewModel
{
    class ComputerGridVM : GridVMBase
    {
        public ComputerGridVM(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
            : base(humanPlayer, computerPlayer)
        {
        }

        public override List<List<SeaSquare>> MyGrid
        {
            get
            {
                return _humanPlayer.EnemyGrid;
            }
        }


        public override void Clicked(SeaSquare square)
        {
            if (square.Type != SquareType.Unknown)
            {
                MessageBox.Show("Please choose a new square");
                return;
            }

            int damagedIndex;
            bool isSunk;
            SquareType newType = _computerPlayer.FiredAt(square.Row, square.Col, out damagedIndex, out isSunk);
            _humanPlayer.EnemyGrid[square.Row][square.Col].ShipIndex = damagedIndex;
            if (isSunk)
                _humanPlayer.EnemySunk(damagedIndex);
            else
                _humanPlayer.EnemyGrid[square.Row][square.Col].Type = newType;
            OnRaiseRefresh();
        }
    }
}
