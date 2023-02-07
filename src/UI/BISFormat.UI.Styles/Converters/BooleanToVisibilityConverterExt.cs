using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows;

namespace BISFormat.UI.Styles.Converters
{
    public class BooleanToVisibilityConverterExt : MarkupExtension, IValueConverter
    {
        public bool Invert { get; set; }
        public Visibility Invisibility { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = value as bool?;
            if (state == null)
                return Invert ? Invisibility : Visibility.Visible;

            if (state == true)
                return Invert ? Visibility.Visible : Invisibility;

            return Invert ? Invisibility : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
