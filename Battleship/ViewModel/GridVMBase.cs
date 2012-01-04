using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship.Model;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;

namespace Battleship.ViewModel
{
    abstract class GridVMBase
    {
        protected Player _player;

        public List<List<SeaSquare>> MyGrid
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

        public virtual void Clicked(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
