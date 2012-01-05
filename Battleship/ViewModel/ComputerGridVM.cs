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

        public List<List<SeaSquare>> MyGrid
        {
            get
            {
                return _humanPlayer.EnemyGrid;
            }
        }

        public void Refresh()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(MyGrid);
            collectionView.Refresh();
        }

        public override void Clicked(SeaSquare square)
        {
            if (square.Type != SquareType.Unknown)
            {
                MessageBox.Show("Please choose a new square");
                return;
            }

            SquareType newType = _computerPlayer.FiredAt(square.Row, square.Col);
            _humanPlayer.EnemyGrid[square.Row][square.Col].Type = newType;
            Refresh();
        }
    }
}
