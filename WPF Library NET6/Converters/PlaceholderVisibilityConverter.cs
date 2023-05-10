using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPFLibrary.Converters;

public sealed class PlaceholderVisibilityConverter : IValueConverter
{
    public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
    {
        return string.IsNullOrWhiteSpace(value.ToString())
                   ? Visibility.Visible
                   : Visibility.Hidden;
    }

    public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}