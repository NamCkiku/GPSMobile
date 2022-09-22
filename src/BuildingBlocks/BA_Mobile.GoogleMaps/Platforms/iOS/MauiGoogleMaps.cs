using BA_Mobile.GoogleMaps.Handlers;
using Google.Maps;

namespace BA_Mobile.GoogleMaps.iOS
{
    public static class MauiGoogleMaps
    {
        public static bool IsInitialized { get; private set; }

        public static void Init(string apiKey, PlatformConfig config = null)
        {
            MapServices.ProvideApiKey(apiKey);
            GeocoderBackend.Register();
            MapHandler.Config = config ?? new PlatformConfig();
            IsInitialized = true;
        }
    }
}