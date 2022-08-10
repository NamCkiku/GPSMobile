using BA_Mobile.Core;
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
            builder.Services.AddServicesGPSMobile();
            return builder;
        }
    }
}