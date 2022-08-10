using BA_Mobile.Service;
using GPSMobile.Core.Views;
using GPSMobile.Service;

namespace GPSMobile.Core
{
    public static class Extensions
    {
        public static MauiAppBuilder Configure(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.ConfigurePages()
                .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
            });
            builder.Services.AddServicesCore();
            builder.Services.AddServicesGPSMobile();
            return builder;
        }
    }
}