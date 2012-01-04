using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship.Model;
using System.Windows.Data;
using System.ComponentModel;

namespace Battleship.ViewModel
{
    class GridVMBase
    {
        protected Player _player;

        public List<List<SquareType>> MyGrid
        //public List<List<string>> MyGrid
        {
            get
            {
                return _player.MyGrid;
            }
        }

        public void Refresh()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(_player.MyGrid);
            collectionView.Refresh();
        }
    }
}
