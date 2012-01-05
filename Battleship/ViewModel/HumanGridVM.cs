using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship.Model;
using System.Windows.Data;
using System.ComponentModel;

namespace Battleship.ViewModel
{
    class HumanGridVM: GridVMBase
    {
        public HumanGridVM(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
            : base(humanPlayer, computerPlayer)
        {
        }

        public override List<List<SeaSquare>> MyGrid
        {
            get
            {
                return _humanPlayer.MyGrid;
            }
        }

        public override void Clicked(SeaSquare content)
        {
        }
    }
}
