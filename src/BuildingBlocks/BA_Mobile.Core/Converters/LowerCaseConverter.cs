using System.Globalization;

namespace BA_Mobile.Core
{
    public class LowerCaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            string stringValue = value.ToString();

            if (string.IsNullOrEmpty(stringValue))
                return string.Empty;
            else
                return stringValue.Trim().ToLower();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}