using BA_Mobile.Core.Resources;
using BA_Mobile.Entities.Enums;
using System.Globalization;

namespace BA_Mobile.Core
{
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return CommonResource.Common_Label_Other;
            }
            switch ((Gender)value)
            {
                case Gender.Female:
                    return CommonResource.Common_Label_Female;

                case Gender.Male:
                    return CommonResource.Common_Label_Male;

                case Gender.Orther:
                    return CommonResource.Common_Label_Other;
            }
            return CommonResource.Common_Label_Other;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}