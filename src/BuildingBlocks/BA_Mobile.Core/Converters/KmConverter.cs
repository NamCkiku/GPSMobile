using BA_Mobile.Utilities;
using System.Globalization;

namespace BA_Mobile.Core
{
    public class KmConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            float val = float.Parse(value.ToString());

            if (val == 0)
                return $"0 Km";
            else
                return string.Format("{0} Km", Math.Round(val, 2));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class MetToKmConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            float val = float.Parse(value.ToString());

            if (val == 0)
                return $"0 km";
            else
                return $"{FormatHelper.FormatNumber(Math.Round(val / 1000, 2))} km";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class DistanceToKmConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return 0;
            }
            else
            {
                try
                {
                    float val = float.Parse(value.ToString());
                    return FormatHelper.FormatNumber(Math.Round(val / 1000, 2));
                }
                catch (Exception)
                {
                }
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}