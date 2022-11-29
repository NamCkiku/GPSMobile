using BA_Mobile.Core.Constant;
using BA_Mobile.Core.Interfaces;
using BA_Mobile.Core.Views;
using BA_Mobile.Service;
using Mopups.Hosting;

namespace BA_Mobile.Core
{
    public static class Extensions
    {
        public static int CurrentLanguage = Settings.CurrentLanguage;

        public static MauiAppBuilder ConfigureMobileCore(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder
                .ConfigurePages()
                .ConfigureService()
                .ConfigureMopups()
                .ConfigureEssentials(essentials =>
                {
                    essentials.UseVersionTracking();
                });
            builder.Services.AddServicesCore();
            return builder;
        }
    }
}