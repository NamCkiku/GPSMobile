using System.Globalization;

namespace BA_Mobile.Core
{
    public class UnitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }
            if (parameter == null || string.IsNullOrEmpty(parameter.ToString()))
            {
                return $"{value.ToString()} {"phương tiện"}";
            }
            return $"{value.ToString()} {parameter.ToString().Trim().ToLower()}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return default;
        }
    }

    public class NMConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value == null)
                {
                    return string.Empty;
                }
                if (parameter == null || string.IsNullOrEmpty(parameter.ToString()))
                {
                    return Math.Round((System.Convert.ToSingle(value) / 1.852)).ToString();
                }

                return $"{(System.Convert.ToSingle(value) / 1.852).ToString("F", CultureInfo.InvariantCulture)} {parameter.ToString()}";
            }
            catch
            {
                return $"{0.00} {parameter.ToString()}";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return default;
        }
    }
}