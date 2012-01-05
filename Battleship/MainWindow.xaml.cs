using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Battleship.ViewModel;
using Battleship.Model;

namespace Battleship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HumanPlayer _humanPlayer = new HumanPlayer();
        ComputerPlayer _computerPlayer = new ComputerPlayer();

        HumanGridVM _humanGrid;
        ComputerGridVM _computerGrid;
        
        public MainWindow()
        {
            _humanGrid = new HumanGridVM(_humanPlayer, _computerPlayer);
            _computerGrid = new ComputerGridVM(_humanPlayer, _computerPlayer);
        
            InitializeComponent();
            humanGrid.DataContext = _humanGrid;
            computerGrid.DataContext = _computerGrid;
            _humanGrid.Refresh();
        }

        private void ExecutedNewGame(object sender, ExecutedRoutedEventArgs e)
        {
            _humanPlayer.Reset();
            _computerPlayer.Reset();
            _humanGrid.Refresh();
            _computerGrid.Refresh();
        }

        private void ExecutedExit(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
