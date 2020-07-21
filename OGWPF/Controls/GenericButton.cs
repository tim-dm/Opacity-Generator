using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OGWPF.Controls
{
    public class GenericButton : Button
    {
        public static readonly DependencyProperty BackgroundHoverProperty =
           DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(GenericButton));

        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), typeof(GenericButton), new FrameworkPropertyMetadata(Brushes.Orange,
                new PropertyChangedCallback(OnColorHoverChanged)));

        public static readonly DependencyProperty BorderRadiusProperty =
           DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(GenericButton));

        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.Register("ForegroundHover", typeof(Brush), typeof(GenericButton), new FrameworkPropertyMetadata(Brushes.White,
                new PropertyChangedCallback(OnForegroundHoverChanged)));

        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        public Brush BackgroundPressed
        {
            get { return (Brush)GetValue(BackgroundPressedProperty); }
            set
            {
                SetValue(BackgroundPressedProperty, value);
            }
        }

        public Brush ForegroundHover
        {
            get { return (Brush)GetValue(ForegroundHoverProperty); }
            set
            {
                SetValue(ForegroundHoverProperty, value);
            }
        }

        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

        private static void OnColorHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (((GenericButton)d).BackgroundPressed == null)
                ((GenericButton)d).BackgroundPressed = ((GenericButton)d).Background;
        }

        private static void OnForegroundHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (((GenericButton)d).ForegroundHover == null)
                ((GenericButton)d).ForegroundHover = ((GenericButton)d).Foreground;
        }
    }
}
