using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OGWPF.Controls
{
    public class GenericTabControl : TabControl
    {
        //Tabs
        public static readonly DependencyProperty TabBackgroundProperty =
           DependencyProperty.Register("TabBackground", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabBorderBrushProperty =
           DependencyProperty.Register("TabBorder", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabBorderThicknessProperty =
            DependencyProperty.Register("TabBorderThickness", typeof(Thickness), typeof(GenericTabControl));

        //Active Tab
        public static readonly DependencyProperty TabActiveBackgroundProperty =
           DependencyProperty.Register("TabActiveBackground", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabActiveBorderBrushProperty =
          DependencyProperty.Register("TabActiveBorderBrush", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabActiveBorderThicknessProperty =
          DependencyProperty.Register("TabActiveBorderThickness", typeof(Thickness), typeof(GenericTabControl));

        public static readonly DependencyProperty TabActiveForegroundProperty =
          DependencyProperty.Register("TabActiveForeground", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabCornerRadiusProperty =
            DependencyProperty.Register("TabCornerRadius", typeof(CornerRadius), typeof(GenericTabControl));

        public Brush TabBackground
        {
            get { return (Brush)GetValue(TabBackgroundProperty); }
            set { SetValue(TabBackgroundProperty, value); }
        }

        public Brush TabBorderBrush
        {
            get { return (Brush)GetValue(TabBorderBrushProperty); }
            set { SetValue(TabBorderBrushProperty, value); }
        }

        public Thickness TabBorderThickness
        {
            get { return (Thickness)GetValue(TabBorderThicknessProperty); }
            set { SetValue(TabBorderThicknessProperty, value); }
        }

        public Brush TabActiveBackground
        {
            get { return (Brush)GetValue(TabActiveBackgroundProperty); }
            set { SetValue(TabActiveBackgroundProperty, value); }
        }

        public Brush TabActiveBorderBrush
        {
            get { return (Brush)GetValue(TabActiveBorderBrushProperty); }
            set { SetValue(TabActiveBorderBrushProperty, value); }
        }

        public Thickness TabActiveBorderThickness
        {
            get { return (Thickness)GetValue(TabActiveBorderThicknessProperty); }
            set { SetValue(TabActiveBorderThicknessProperty, value); }
        }

        public Brush TabActiveForeground
        {
            get { return (Brush)GetValue(TabActiveForegroundProperty); }
            set { SetValue(TabActiveForegroundProperty, value); }
        }

        public CornerRadius TabCornerRadius
        {
            get { return (CornerRadius)GetValue(TabCornerRadiusProperty); }
            set { SetValue(TabCornerRadiusProperty, value); }
        }


        // Tab Panel
        public static readonly DependencyProperty TabPanelBackgroundProperty =
           DependencyProperty.Register("TabPanelBackground", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabPanelBorderBrushProperty =
           DependencyProperty.Register("TabPanelBorderBrush", typeof(Brush), typeof(GenericTabControl));


        public static readonly DependencyProperty TabPanelBorderThicknessProperty =
            DependencyProperty.Register("TabPanelBorderThickness", typeof(Thickness), typeof(GenericTabControl));

        public static readonly DependencyProperty TabPanelUniformProperty =
            DependencyProperty.Register("TabPanelUniform", typeof(bool), typeof(GenericTabControl), new PropertyMetadata(false));

        public Brush TabPanelBackground
        {
            get { return (Brush)GetValue(TabPanelBackgroundProperty); }
            set { SetValue(TabPanelBackgroundProperty, value); }
        }

        public Brush TabPanelBorderBrush
        {
            get { return (Brush)GetValue(TabPanelBorderBrushProperty); }
            set { SetValue(TabPanelBorderBrushProperty, value); }
        }

        public Thickness TabPanelBorderThickness
        {
            get { return (Thickness)GetValue(TabPanelBorderThicknessProperty); }
            set { SetValue(TabPanelBorderThicknessProperty, value); }
        }

        public bool TabPanelUniform
        {
            get { return (bool)GetValue(TabPanelUniformProperty); }
            set { SetValue(TabPanelUniformProperty, value); }
        }


        //Tab Item
        public static readonly DependencyProperty TabItemBackgroundProperty =
            DependencyProperty.Register("TabItemBackground", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabItemBorderBrushProperty =
            DependencyProperty.Register("TabItemBorderBrush", typeof(Brush), typeof(GenericTabControl));

        public static readonly DependencyProperty TabItemBorderThicknessProperty =
            DependencyProperty.Register("TabItemBorderThickness", typeof(Thickness), typeof(GenericTabControl));

        public Brush TabItemBackground
        {
            get { return (Brush)GetValue(TabItemBackgroundProperty); }
            set { SetValue(TabItemBackgroundProperty, value); }
        }

        public Brush TabItemBorderBrush
        {
            get { return (Brush)GetValue(TabItemBorderBrushProperty); }
            set { SetValue(TabItemBorderBrushProperty, value); }
        }

        public Thickness TabItemBorderThickness
        {
            get { return (Thickness)GetValue(TabItemBorderThicknessProperty); }
            set { SetValue(TabItemBorderThicknessProperty, value); }
        }

    }
}
