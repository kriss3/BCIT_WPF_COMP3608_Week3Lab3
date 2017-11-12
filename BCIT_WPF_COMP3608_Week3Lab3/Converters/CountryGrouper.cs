using System;
using System.Globalization;
using System.Windows.Data;

namespace BCIT_WPF_COMP3608_Week3Lab3.Converters
{
    class CountryGrouper : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string country = value.ToString();
            return $"Country: {country}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
