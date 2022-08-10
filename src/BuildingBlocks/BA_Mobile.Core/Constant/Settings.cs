using BA_Mobile.Utilities.Constant;

namespace BA_Mobile.Core.Constant
{
    public static class Settings
    {
        private const string IdLatitude = "latitude";
        private static readonly float LatitudeDefault = 20.973993f;

        private const string IdLongitude = "longitude";
        private static readonly float LongitudeDefault = 105.846421f;

        private const string UserNameKey = "user_name_key";
        private static readonly string UserNameDefault = string.Empty;

        private const string PasswordKey = "password_key";
        private static readonly string PasswordDefault = string.Empty;

        private const string RemembermeKey = "remember_me_key";
        private static readonly bool RemembermeDefault = false;

        private const string CurrentLanguageKey = "current_language_key";
        private static readonly int CurrentLanguageDefault = CultureCountry.Vietnamese;

        private const string AppVersionDBKey = "AppVersionDBKey";
        private static readonly string AppVersionDBDefault = string.Empty;

        private const string AppLinkDownloadKey = "AppLinkDownloadKey";
        private static readonly string AppLinkDownloadDefault = string.Empty;

        private const string IsFistInstallAppKey = "IsFistInstallAppKey";
        private static readonly bool IsFistInstallAppDefault = false;

        private const string FavoritesVehicleImageKey = "FavoritesVehicleImageKey";
        private static readonly string FavoritesVehicleImageDefault = string.Empty;

        private const string FavoritesVehicleOnlineKey = "FavoritesVehicleOnlineKey";
        private static readonly string FavoritesVehicleOnlineDefault = string.Empty;

        private const string FavoritesIssueKey = "FavoritesIssueKey";
        private static readonly string FavoritesIssueDefault = string.Empty;

        private const string FirebaseToken = "firebase_token";
        private static readonly string FirebaseTokenDefault = string.Empty;
        private const string CurrentCompanyKey = "current_company_key";
        private static readonly string CurrentCompanyDefault = string.Empty;

        private const string ReceivedNotificationTypeKey = "ReceivedNotificationTypeKey";
        private static readonly string ReceivedNotificationTypeDefault = string.Empty;

        private const string ReceivedNotificationValueKey = "ReceivedNotificationValueKey";
        private static readonly string ReceivedNotificationValueDefault = string.Empty;

        private const string ReceivedNotificationTitleKey = "ReceivedNotificationTitleKey";
        private static readonly string ReceivedNotificationTitleDefault = string.Empty;

        private const string CurrentThemeKey = "CurrentThemeKey";
        private static readonly string CurrentThemeDefault = "Light";

        private const string IsUpdateAppKey = "IsUpdateAppKey";
        private static readonly bool IsUpdateAppDefault = false;
        private const string MapTypeKey = "MapTypeKey";

        public static float Latitude
        {
            get => Preferences.Get(IdLatitude, LatitudeDefault);
            set => Preferences.Set(IdLatitude, value);
        }

        public static float Longitude
        {
            get => Preferences.Get(IdLongitude, LongitudeDefault);
            set => Preferences.Set(IdLongitude, value);
        }

        /// <summary>
        /// Lưu thông tin đăng nhập
        /// </summary>
        public static string UserName
        {
            get => Preferences.Get(UserNameKey, UserNameDefault);
            set => Preferences.Set(UserNameKey, value);
        }

        /// <summary>
        /// Lưu thông tin mật khẩu
        /// </summary>
        public static string Password
        {
            get => Preferences.Get(PasswordKey, PasswordDefault);
            set => Preferences.Set(PasswordKey, value);
        }

        /// <summary>
        /// Lưu thông tin ghi nho mat khau
        /// </summary>
        public static bool Rememberme
        {
            get => Preferences.Get(RemembermeKey, RemembermeDefault);
            set => Preferences.Set(RemembermeKey, value);
        }

        /// <summary>
        /// ngôn ngữ hiện tại được chọn
        /// </summary>
        public static int CurrentLanguage
        {
            get => Preferences.Get(CurrentLanguageKey, CurrentLanguageDefault);
            set => Preferences.Set(CurrentLanguageKey, value);
        }

        /// <summary>
        /// Lưu thông tin Token hiện tại của Firebase
        /// </summary>
        public static string CurrentFirebaseToken
        {
            get => Preferences.Get(FirebaseToken, FirebaseTokenDefault);
            set => Preferences.Set(FirebaseToken, value);
        }

        public static string ReceivedNotificationType
        {
            get => Preferences.Get(ReceivedNotificationTypeKey, ReceivedNotificationTypeDefault);
            set => Preferences.Set(ReceivedNotificationTypeKey, value);
        }

        public static string ReceivedNotificationValue
        {
            get => Preferences.Get(ReceivedNotificationValueKey, ReceivedNotificationValueDefault);
            set => Preferences.Set(ReceivedNotificationValueKey, value);
        }

        public static string ReceivedNotificationTitle
        {
            get => Preferences.Get(ReceivedNotificationTitleKey, ReceivedNotificationTitleDefault);
            set => Preferences.Set(ReceivedNotificationTitleKey, value);
        }

        public static string CurrentTheme
        {
            get => Preferences.Get(CurrentThemeKey, CurrentThemeDefault);
            set => Preferences.Set(CurrentThemeKey, value);
        }

        public static bool IsUpdateApp
        {
            get => Preferences.Get(IsUpdateAppKey, IsUpdateAppDefault);
            set => Preferences.Set(IsUpdateAppKey, value);
        }

        public static int MapType
        {
            get => Preferences.Get(MapTypeKey, 1);
            set => Preferences.Set(MapTypeKey, value);
        }

        public static string FavoritesVehicleOnline
        {
            get => Preferences.Get(FavoritesVehicleOnlineKey, FavoritesVehicleOnlineDefault);
            set => Preferences.Set(FavoritesVehicleOnlineKey, value);
        }
    }
}