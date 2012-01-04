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
        public HumanGridVM()
        {
            _player = new HumanPlayer();
        }
    }
}
