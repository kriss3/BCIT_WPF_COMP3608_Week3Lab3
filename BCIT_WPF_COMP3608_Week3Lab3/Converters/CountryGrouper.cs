using System;
using System.Globalization;
using System.Windows.Data;

namespace BCIT_WPF_COMP3608_Week3Lab3.Converters
{
    /// <summary>
    /// Custom converter class
    /// Krzysztof Szczurowski
    /// Repe address: https://github.com/kriss3/BCIT_WPF_COMP3608_Week3Lab3.git
    /// </summary>
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
