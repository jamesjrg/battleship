using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using Battleship.Model;
using System.Windows.Media;
using System.Globalization;

namespace Battleship.View
{
    [ValueConversion(typeof(SquareType), typeof(Brush))]
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            SquareType type = (SquareType)value;

            switch (type)
            {
                case SquareType.Unknown:
                    return new SolidColorBrush(Colors.LightGray);
                case SquareType.Water:
                    return new SolidColorBrush(Colors.LightBlue);
                case SquareType.Undamaged:
                    return new SolidColorBrush(Colors.Black);
                case SquareType.Damaged:
                    return new SolidColorBrush(Colors.Orange);
                case SquareType.Sunk:
                    return new SolidColorBrush(Colors.Red);
            }

            throw new Exception("fail");
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
