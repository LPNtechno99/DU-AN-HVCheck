using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace GUI
{
    public class ColorPASSConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ReceviedDataFromCamera.StatusCheck)
            {
                if ((ReceviedDataFromCamera.StatusCheck)value == ReceviedDataFromCamera.StatusCheck.PASS)
                {
                    return new SolidColorBrush(Color.FromRgb(70, 197, 70));
                }
            }
            return new SolidColorBrush(Color.FromRgb(211, 211, 211));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ColorFAILConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ReceviedDataFromCamera.StatusCheck)
            {
                if ((ReceviedDataFromCamera.StatusCheck)value == ReceviedDataFromCamera.StatusCheck.FAIL)
                {
                    return new SolidColorBrush(Color.FromRgb(230, 106, 93));
                }
            }
            return new SolidColorBrush(Color.FromRgb(211, 211, 211));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
