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
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ReceviedDataFromCamera.StatusCheck)
            {
                switch((ReceviedDataFromCamera.StatusCheck)value)
                {
                    case ReceviedDataFromCamera.StatusCheck.PASS:
                        return new SolidColorBrush(Color.FromRgb(70, 197, 70));
                    case ReceviedDataFromCamera.StatusCheck.FAIL:
                        return new SolidColorBrush(Color.FromRgb(232, 76, 60));
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
