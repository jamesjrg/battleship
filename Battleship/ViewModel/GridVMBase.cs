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
        protected HumanPlayer _humanPlayer;
        protected ComputerPlayer _computerPlayer;

        private event EventHandler RaiseRefreshEvent;

        public GridVMBase(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
        {
            _humanPlayer = humanPlayer;
            _computerPlayer = computerPlayer;

            RaiseRefreshEvent += this.HandleRefreshEvent;
        }

        public void Refresh()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(MyGrid);
            collectionView.Refresh();
        }

        void HandleRefreshEvent(object sender, EventArgs e)
        {
            Refresh();
        }

        protected void OnRaiseRefresh()
        {
            RaiseRefreshEvent(this, null);
        }

        public abstract void Clicked(SeaSquare content);
        public abstract List<List<SeaSquare>> MyGrid { get; }
    }
}
