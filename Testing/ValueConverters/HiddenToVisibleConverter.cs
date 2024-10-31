using System.Globalization;
using System.Windows;
using Testing.ValueConverters;

namespace Testing.ValueConverters;

public class HiddenToVisibleConverter:BaseValueConverter<HiddenToVisibleConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? Visibility.Visible : Visibility.Hidden;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}