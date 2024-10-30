﻿using System.Globalization;
using System.Windows;

namespace MainChart.ValueConverters;

public class BooleanToVisiblityConverter:BaseValueConverter<BooleanToVisiblityConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? Visibility.Hidden : Visibility.Visible;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}