using BA_Mobile.Core;
using BA_Mobile.Core.Views;
using BA_Mobile.GoogleMaps.Hosting;
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
            builder.ConfigureMobileCore()
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
            return builder;
        }

        public static MauiAppBuilder ConfigurePrism(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.UsePrism(configurePrism: prism =>
            {
                prism.RegisterTypes(OnRegisterTypes)
                .ConfigureServices(ConfigureServices)
                .OnInitialized(OnInitialized)
                .OnAppStart(async navigationService =>
                {
                    navigationService.CreateBuilder()
                    .AddNavigationPage();
                    var result = await navigationService.NavigateAsync("NavigationPage/MainPage");
                    if (!result.Success)
                    {
                        System.Diagnostics.Debugger.Break();
                    }
                });
            });
            return builder;
        }
        public static void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
        public static void OnRegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.ConfigurePagesCore();
            containerRegistry.ConfigurePages();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddServicesCore();
            services.AddServicesGPSMobile();
        }
    }
}