using BA_Mobile.Core;
using BA_Mobile.GoogleMaps.Hosting;
using BA_Mobile.Service;
using GPSMobile.Core.ViewModels;
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
                .ConfigurePrism()
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

        public static MauiAppBuilder ConfigurePrism(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.UsePrism(configurePrism: prism =>
            {
                prism.RegisterTypes(container =>
                {
                    container.RegisterForNavigation<MainPage, MainPageViewModel>();
                })
                .ConfigureServices(container =>
                {
                    container.AddServicesCore();
                    container.AddServicesGPSMobile();
                })
                .OnInitialized(container =>
                {
                    //var foo = container.Resolve<IFoo>();
                    // Do some initializations here
                })
                .ConfigureLogging(builder =>
                {
                    //builder.AddConsole();
                })
                .OnAppStart(async navigationService =>
                {
                    var result = await navigationService.NavigateAsync("MainPage");
                    if (!result.Success)
                    {
                        System.Diagnostics.Debugger.Break();
                    }
                });
            });
            return builder;
        }
    }
}