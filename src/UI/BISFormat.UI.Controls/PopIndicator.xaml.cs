using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BISFormat.UI.Controls
{
    public partial class PopIndicator : UserControl
    {
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(SolidColorBrush), typeof(PopIndicator));
        public SolidColorBrush Color
        {
            get => (SolidColorBrush)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public static readonly DependencyProperty ImagePathGeometryProperty = DependencyProperty.Register("ImagePathGeometry", typeof(string), typeof(PopIndicator));
        public string ImagePathGeometry
        {
            set => SetValue(ImagePathGeometryProperty, value);
        }

        public static readonly DependencyProperty ShowPopProperty = DependencyProperty.Register("ShowPop", typeof(bool), typeof(PopIndicator));
        public bool ShowPop
        {
            set => SetValue(ShowPopProperty, value);
        }

        public static readonly DependencyProperty ShowShakeProperty = DependencyProperty.Register("ShowShake", typeof(bool), typeof(PopIndicator));
        public bool ShowShake
        {
            set => SetValue(ShowShakeProperty, value);
        }

        public PopIndicator()
        {
            InitializeComponent();
        }
    }
}
