using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace InfoBar.Converters
{
    public class BooleanToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = (bool?)value;
            if (state == null)
          
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF005EB8"));
           
            if (state == true)
          
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7896D2"));
           

            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF005EB8"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
