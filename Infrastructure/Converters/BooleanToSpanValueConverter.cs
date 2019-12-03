using System;
using System.Globalization;
using System.Windows.Data;


namespace Infrastructure.Converters
{
    public class BooleanToSpanValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = (bool?)value;
            if (state == null)

                return 1;

            if (state == true)

                return 2;


            return 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
