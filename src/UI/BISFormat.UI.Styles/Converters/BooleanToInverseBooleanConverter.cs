using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace BISFormat.UI.Styles.Converters
{
    public class BooleanToInverseBooleanConverter : MarkupExtension, IValueConverter
    {
        public bool DefaultValue { get; set; } = false;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = value as bool?;
            if (state == null)
                return DefaultValue;

            if (state == true)
                return false;

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = value as bool?;
            if (state == null)
                return DefaultValue;

            if (state == true)
                return false;

            return true;
        }
    }
}
