using BA_Mobile.Utilities.Constant;
using System.Globalization;

namespace BA_Mobile.Core
{
    public class AddRootImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "avatar_default.png";
            }

            if (string.IsNullOrEmpty(value.ToString()))
                return "avatar_default.png";
            else
                if (!value.ToString().Contains("/"))
            {
                return value.ToString();
            }
            else
            {
                return $"{ServerConfig.ApiEndpoint}{value.ToString()}";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class AddRootImageAvatarCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "avatar_default.png";
            }

            if (string.IsNullOrEmpty(value.ToString()))
                return "avatar_default.png";
            else
                if (!value.ToString().Contains("/"))
            {
                return value.ToString();
            }
            else
            {
                return $"{value.ToString()}";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}