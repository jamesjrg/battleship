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

        //for design mode only
        public HumanGridVM()
            : base(null, null)
        {
            _humanPlayer = new HumanPlayer();
        }

        public override List<List<SeaSquare>> MyGrid
        {
            get
            {
                return _humanPlayer.MyGrid;
            }
        }

        public override bool Clicked(SeaSquare content, bool automated)
        {
            return false;
        }
    }
}
