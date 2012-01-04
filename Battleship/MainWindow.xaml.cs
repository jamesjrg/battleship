using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Battleship.ViewModel;

namespace Battleship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HumanGridVM _humanGrid = new HumanGridVM();
        ComputerGridVM _computerGrid = new ComputerGridVM();

        public MainWindow()
        {
            InitializeComponent();
            humanGrid.DataContext = _humanGrid;
            computerGrid.DataContext = _computerGrid;
            _humanGrid.Refresh();
        }

        private void ExecutedNewGame(object sender, ExecutedRoutedEventArgs e)
        {
            //xxx
        }

        private void ExecutedExit(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
