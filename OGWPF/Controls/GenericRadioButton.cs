using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OGWPF.Controls
{
    public class GenericRadioButton : RadioButton
    {
        public static readonly DependencyProperty DotColorProperty =
           DependencyProperty.Register("DotFill", typeof(Brush), typeof(GenericRadioButton));

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(GenericRadioButton));

        public static readonly DependencyProperty CheckedBorderProperty =
            DependencyProperty.Register("CheckedBorder", typeof(Brush), typeof(GenericRadioButton));

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", typeof(double), typeof(GenericRadioButton), new UIPropertyMetadata(2.0));

        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.Register("HoverBorderBrush", typeof(Brush), typeof(GenericRadioButton));

        public Brush DotFill
        {
            get { return (Brush)GetValue(DotColorProperty); }
            set { SetValue(DotColorProperty, value); }
        }

        public Brush CheckedBackground
        {
            get { return (Brush)GetValue(CheckedBackgroundProperty); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public Brush CheckedBorder
        {
            get { return (Brush)GetValue(CheckedBorderProperty); }
            set { SetValue(CheckedBorderProperty, value); }
        }

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }



        private static void OnStrokeThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (((GenericRadioButton)d).StrokeThickness < 1)
                ((GenericRadioButton)d).StrokeThickness = 2;
        }
    }
}