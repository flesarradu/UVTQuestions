using System;
using System.Globalization;

namespace UVTQuestions.Converters
{
	public class IsImageSourceConverter : IValueConverter
    { 
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (((string)value).Contains(".png"))
                {
                    if (File.Exists((string)value))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

