﻿using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace MainChart.ValueConverters;

public abstract class BaseValueConverter<T>:MarkupExtension, IValueConverter
    where T : class, new()
{

    #region Private Members

    private static T mConverter = null;

    #endregion

    #region Markup Extension Methods

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return mConverter ??= new T();
    }

    #endregion

    #region Converter Methods
    public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

    public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);


    #endregion
}