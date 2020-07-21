using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace OGWPF.Converters
{
    public class BooleanToVisibilityConverter : DependencyObject, IValueConverter
    {
        //Register the `IsInverse` property below
        public static readonly DependencyProperty IsInversedProperty =
            DependencyProperty.Register("IsInversed", typeof(Boolean), typeof(BooleanToVisibilityConverter));

        //Allow the DependencyObject to Set and Get registered values
        public bool IsInversed
        {
            get { return (bool)GetValue(IsInversedProperty); }
            set { SetValue(IsInversedProperty, value); }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isVisible = (bool)value;

            //Check is inversed is true, if so invert the current value.
            if (IsInversed)
                isVisible = !isVisible;

            //Check current value and return
            if (isVisible)
                return Visibility.Visible;

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
