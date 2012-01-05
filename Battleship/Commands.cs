using System;
using System.Windows.Input;

namespace Battleship
{
    class Commands
    {
        public static readonly RoutedUICommand NewGame = new RoutedUICommand(
            "_New Game", "New Game", typeof(Commands),
            new InputGestureCollection { new KeyGesture(Key.F2) });
        public static readonly RoutedUICommand Exit = new RoutedUICommand(
            "E_xit", "Exit", typeof(Commands),
            new InputGestureCollection { new KeyGesture(Key.F4, ModifierKeys.Alt) });
    }
}
