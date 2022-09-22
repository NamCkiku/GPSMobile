using BA_Mobile.Core;
using BA_Mobile.GoogleMaps.Hosting;
using GPSMobile.Core.Views;
using GPSMobile.Service;

namespace GPSMobile.Core
{
    public static class Extensions
    {
        public static MauiAppBuilder Configure(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.ConfigureMobileCore()
                .ConfigurePages()
                .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
            });
#if ANDROID
            var platformConfig = new BA_Mobile.GoogleMaps.Android.PlatformConfig
            {
                BitmapDescriptorFactory = new GPSMobile.Core.Platforms.Android.CachingNativeBitmapDescriptorFactory()
            };

            builder.UseGoogleMaps(platformConfig);
#elif IOS
            var platformConfig = new BA_Mobile.GoogleMaps.iOS.PlatformConfig
            {
                ImageFactory = new GPSMobile.Core.Platforms.iOS.CachingImageFactory()
            };

            builder.UseGoogleMaps(BA_Mobile.Utilities.Constant.Config.GoogleMapKeyiOS, platformConfig);
#endif
            builder.Services.AddServicesGPSMobile();
            return builder;
        }
    }
}