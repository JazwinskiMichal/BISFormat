using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace BISFormat.UI.Controls
{
    public partial class ButtonImage : UserControl
    {
        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.Blue));
        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ButtonCornerRadiusProperty = DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(ButtonImage), new PropertyMetadata(4));
        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ButtonBackgroundFocusedProperty = DependencyProperty.Register("ButtonBackgroundFocused", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.BlueFocused));
        public Brush ButtonBackgroundFocused
        {
            get { return (Brush)GetValue(ButtonBackgroundFocusedProperty); }
            set { SetValue(ButtonBackgroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderBrushProperty = DependencyProperty.Register("ButtonBorderBrush", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.Blue));
        public Brush ButtonBorderBrush
        {
            get { return (Brush)GetValue(ButtonBorderBrushProperty); }
            set { SetValue(ButtonBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderBrushFocusedProperty = DependencyProperty.Register("ButtonBorderBrushFocused", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.BlueFocused));
        public Brush ButtonBorderBrushFocused
        {
            get { return (Brush)GetValue(ButtonBorderBrushFocusedProperty); }
            set { SetValue(ButtonBorderBrushFocusedProperty, value); }
        }

        public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register("ButtonForeground", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.White));
        public Brush ButtonForeground
        {
            get { return (Brush)GetValue(ButtonForegroundProperty); }
            set { SetValue(ButtonForegroundProperty, value); }
        }

        public static readonly DependencyProperty ButtonForegroundFocusedProperty = DependencyProperty.Register("ButtonForegroundFocused", typeof(Brush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.White));
        public Brush ButtonForegroundFocused
        {
            get { return (Brush)GetValue(ButtonForegroundFocusedProperty); }
            set { SetValue(ButtonForegroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty ButtonFontFamilyProperty = DependencyProperty.Register("ButtonFontFamily", typeof(FontFamily), typeof(ButtonImage));
        public FontFamily ButtonFontFamily
        {
            get { return (FontFamily)GetValue(ButtonFontFamilyProperty); }
            set { SetValue(ButtonFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty ButtonFontSizeProperty = DependencyProperty.Register("ButtonFontSize", typeof(double), typeof(ButtonImage));
        public double ButtonFontSize
        {
            get { return (double)GetValue(ButtonFontSizeProperty); }
            set { SetValue(ButtonFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register("ButtonText", typeof(string), typeof(ButtonImage), new PropertyMetadata("ButtonImage"));
        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonIconProperty = DependencyProperty.Register("ButtonIcon", typeof(string), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Icons.Circle));
        public string ButtonIcon
        {
            get { return (string)GetValue(ButtonIconProperty); }
            set { SetValue(ButtonIconProperty, value); }
        }

        public static readonly DependencyProperty ButtonIconColorProperty = DependencyProperty.Register("ButtonIconColor", typeof(SolidColorBrush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.White));
        public SolidColorBrush ButtonIconColor
        {
            get => (SolidColorBrush)GetValue(ButtonIconColorProperty);
            set => SetValue(ButtonIconColorProperty, value);
        }

        public static readonly DependencyProperty ButtonIconColorFocusedProperty = DependencyProperty.Register("ButtonIconColorFocused", typeof(SolidColorBrush), typeof(ButtonImage), new PropertyMetadata(Styles.Themes.Brushes.White));
        public SolidColorBrush ButtonIconColorFocused
        {
            get => (SolidColorBrush)GetValue(ButtonIconColorFocusedProperty);
            set => SetValue(ButtonIconColorFocusedProperty, value);
        }

        public static readonly DependencyProperty ButtonIconMarginProperty = DependencyProperty.Register("ButtonIconMargin", typeof(Thickness), typeof(ButtonImage), new PropertyMetadata(new Thickness(4)));
        public Thickness ButtonIconMargin
        {
            get { return (Thickness)GetValue(ButtonIconMarginProperty); }
            set { SetValue(ButtonIconMarginProperty, value); }
        }

        public static readonly DependencyProperty ClickCommandProperty = DependencyProperty.Register("ClickCommand", typeof(ICommand), typeof(ButtonImage));
        public ICommand ClickCommand
        {
            get => (ICommand)GetValue(ClickCommandProperty);
            set => SetValue(ClickCommandProperty, value);
        }

        public static readonly DependencyProperty ClickCommandParamProperty = DependencyProperty.Register("ClickCommandParam", typeof(object), typeof(ButtonImage));
        public object ClickCommandParam
        {
            get => (object)GetValue(ClickCommandParamProperty);
            set => SetValue(ClickCommandParamProperty, value);
        }

        public ButtonImage()
        {
            InitializeComponent();
        }
    }
}
