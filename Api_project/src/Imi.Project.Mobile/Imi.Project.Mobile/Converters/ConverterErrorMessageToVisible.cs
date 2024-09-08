using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Imi.Project.Mobile.Converters
{
    public class ConverterErrorMessageToVisible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value is string)
                {
                    string errorMessage = (string)value;
                    return !string.IsNullOrWhiteSpace(errorMessage);
                }
                else
                {
                    throw new ArgumentException($"{nameof(value)} must be a string");
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
