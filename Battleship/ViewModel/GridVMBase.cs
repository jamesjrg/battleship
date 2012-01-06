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

        public GridVMBase(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
        {
            _humanPlayer = humanPlayer;
            _computerPlayer = computerPlayer;
        }

        public abstract bool Clicked(SeaSquare content, bool automated=false);
        public abstract List<List<SeaSquare>> MyGrid { get; }
    }
}
