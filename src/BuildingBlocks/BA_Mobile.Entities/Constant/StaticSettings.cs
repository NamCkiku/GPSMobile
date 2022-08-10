namespace BA_Mobile.Entities.Constant
{
    public class StaticSettings
    {
        public static string Token { get; set; }

        public static DateTime TimeServer { get; set; }

        public static DateTime TimeSleep { get; set; }

        public static void ClearStaticSettings()
        {
            Token = string.Empty;
        }

        public static bool IsUnauthorized { get; set; }
    }
}