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
        public ComputerGridVM()
        {
            _player = new ComputerPlayer();
        }

        public override void Clicked(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("clicked");
        }
    }
}
