using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BISFormat.UI.Styles.Converters
{
    public class PathColorToImageMultiConverter : MarkupExtension, IMultiValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public string IconIfNull { get; set; } = "M445.66 45.65l-11.31-11.31c-3.12-3.12-8.19-3.12-11.31 0l-75.12 75.12C314.46 81.15 271.26 64 224 64 117.96 64 32 149.96 32 256c0 47.26 17.15 90.46 45.46 123.91L2.34 455.03c-3.12 3.12-3.12 8.19 0 11.31l11.31 11.31c3.12 3.12 8.19 3.12 11.31 0l75.12-75.12C133.54 430.85 176.74 448 224 448c106.04 0 192-85.96 192-192 0-47.26-17.15-90.46-45.46-123.91l75.12-75.12a8.015 8.015 0 0 0 0-11.32zM64 256c0-88.22 71.78-160 160-160 38.34 0 73.1 14.12 100.69 36.69l-224 224C78.11 329.1 64 294.34 64 256zm320 0c0 88.22-71.78 160-160 160-38.34 0-73.1-14.12-100.69-36.69l224-224C369.89 182.9 384 217.66 384 256z";
        public Brush ColorIfNull { get; set; } = new SolidColorBrush(Color.FromRgb(67, 67, 67));

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string icon = string.Empty;
            Brush color = null;
            string value = string.Empty;

            if (values != null && values.Length > 1)
            {
                if (values.All(x => x != null))
                {
                    if (values.FirstOrDefault().GetType().FullName == "MS.Internal.NamedObject")
                        return DrawingImage(IconIfNull, ColorIfNull);
                    else
                    {
                        if (values.Any(x => x.GetType() == typeof(string)))
                            icon = values.FirstOrDefault(x => x.GetType() == typeof(string)).ToString();

                        if (values.Any(x => x.GetType() == typeof(SolidColorBrush)))
                            color = values.FirstOrDefault(x => x.GetType() == typeof(SolidColorBrush)) as SolidColorBrush;

                        return DrawingImage(!string.IsNullOrEmpty(icon) ? icon : IconIfNull, color != null ? color : ColorIfNull);
                    }
                }
                else
                    return DrawingImage(IconIfNull, ColorIfNull);
            }
            else
                return DrawingImage(IconIfNull, ColorIfNull);
        }

        private DrawingImage DrawingImage(string icon, Brush color)
        {
            Path path = new() { Fill = color, Stroke = new SolidColorBrush(Colors.Transparent), StrokeThickness = 0 };
            path.Data = Geometry.Parse(icon);
            var dGroup = new DrawingGroup();
            using (DrawingContext dc = dGroup.Open())
            {
                dc.DrawGeometry(
                     path.Fill,
                     new Pen(path.Stroke, path.StrokeThickness),
                     path.Data);
            }

            return new DrawingImage(dGroup);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
