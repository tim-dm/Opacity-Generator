using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OGWPF.Controls
{
    public class GenericSlider : Slider
    {
        public static readonly DependencyProperty ThumbBackgroundProperty =
            DependencyProperty.Register("ThumbBackground", typeof(Brush), typeof(GenericSlider), new FrameworkPropertyMetadata(Brushes.Orange));

        public static readonly DependencyProperty ThumbBorderBrushProperty =
           DependencyProperty.Register("ThumbBorder", typeof(Brush), typeof(GenericSlider));

        public static readonly DependencyProperty ThumbBorderThicknessProperty =
            DependencyProperty.Register("ThumbBorderThickness", typeof(double), typeof(GenericSlider));

        public static readonly DependencyProperty ThumbWidthProperty =
            DependencyProperty.Register("ThumbWidth", typeof(int), typeof(GenericSlider));

        public static readonly DependencyProperty ThumbHeightProperty =
            DependencyProperty.Register("ThumbHeight", typeof(int), typeof(GenericSlider));

        public static readonly DependencyProperty TickBrushProperty =
           DependencyProperty.Register("TickColor", typeof(Brush), typeof(GenericSlider));

        public static readonly DependencyProperty DecreaseButtonBrushProperty =
           DependencyProperty.Register("DecreaseRepeatButtonBrush", typeof(Brush), typeof(GenericSlider));

        public static readonly DependencyProperty IncreaseButtonBrushProperty =
           DependencyProperty.Register("IncreaseRepeatButtonBrush", typeof(Brush), typeof(GenericSlider));

        public static readonly DependencyProperty UseCircularThumbProperty =
           DependencyProperty.Register("UseCircularThumb", typeof(bool), typeof(GenericSlider), new FrameworkPropertyMetadata(false));

        public Brush ThumbBackground
        {
            get { return (Brush)GetValue(ThumbBackgroundProperty); }
            set { SetValue(ThumbBackgroundProperty, value); }
        }

        public Brush ThumbBorderBrush
        {
            get { return (Brush)GetValue(ThumbBorderBrushProperty); }
            set { SetValue(ThumbBorderBrushProperty, value); }
        }

        public double ThumbBorderThickness
        {
            get { return (double)GetValue(ThumbBorderThicknessProperty); }
            set { SetValue(ThumbBorderThicknessProperty, value); }
        }

        public int ThumbWidth
        {
            get { return (int)GetValue(ThumbWidthProperty); }
            set { SetValue(ThumbWidthProperty, value); }
        }

        public int ThumbHeight
        {
            get { return (int)GetValue(ThumbHeightProperty); }
            set { SetValue(ThumbHeightProperty, value); }
        }

        public Brush TickBrush
        {
            get { return (Brush)GetValue(TickBrushProperty); }
            set { SetValue(TickBrushProperty, value); }
        }

        public Brush DecreaseRepeatButtonBrush
        {
            get { return (Brush)GetValue(DecreaseButtonBrushProperty); }
            set { SetValue(DecreaseButtonBrushProperty, value); }
        }

        public Brush IncreaseRepeatButtonBrush
        {
            get { return (Brush)GetValue(IncreaseButtonBrushProperty); }
            set { SetValue(IncreaseButtonBrushProperty, value); }
        }

        public bool UseCircularThumb
        {
            get { return (bool)GetValue(UseCircularThumbProperty); }
            set { SetValue(UseCircularThumbProperty, value); }
        }

    }
}
