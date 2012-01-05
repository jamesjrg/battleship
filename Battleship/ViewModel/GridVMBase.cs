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

        public event EventHandler RaiseRefreshEvent;

        public GridVMBase(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
        {
            _humanPlayer = humanPlayer;
            _computerPlayer = computerPlayer;
        }

        public void AddEventHandlers(GridVMBase grid1, GridVMBase grid2)
        {
            grid1.RaiseRefreshEvent += this.HandleRefreshEvent;
            grid2.RaiseRefreshEvent += this.HandleRefreshEvent;
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

        public abstract bool Clicked(SeaSquare content, bool automated=false);
        public abstract List<List<SeaSquare>> MyGrid { get; }
    }
}
