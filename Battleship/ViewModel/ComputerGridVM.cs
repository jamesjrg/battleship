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

        //returns true if game is over
        public override bool Clicked(SeaSquare square, bool automated)
        {
            bool gameOver = false;

            if (automated)
                _humanPlayer.TakeTurnAutomated(_computerPlayer);
            else
            {
                if (square.Type != SquareType.Unknown)
                {
                    MessageBox.Show("Please choose a new square");
                    gameOver = false;
                }

                _humanPlayer.TakeTurn(square.Row, square.Col, _computerPlayer);
            }

            if (_computerPlayer.NoShipsSadFace())
            {
                MessageBox.Show("You win!");
                gameOver = true;
            }
            else
            {
                _computerPlayer.TakeTurn(_humanPlayer);
                if (_humanPlayer.NoShipsSadFace())
                {
                    MessageBox.Show("You lose :(");
                    gameOver = true;
                }
            }
            return gameOver;
        }
    }
}
