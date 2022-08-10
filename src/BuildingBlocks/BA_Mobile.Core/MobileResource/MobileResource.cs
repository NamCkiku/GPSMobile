using BA_Mobile.Utilities.Constant;

namespace BA_Mobile.Core.Resources
{
    public partial class MobileResource
    {
        public static string Get(string defaultValue, string defaultValueEng)
        {
            var val = Extensions.CurrentLanguage == CultureCountry.Vietnamese ? defaultValue : defaultValueEng;
            return val;
        }
    }
}