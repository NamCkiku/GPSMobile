using BA_Mobile.Core.Views;
using BA_Mobile.Service;

namespace BA_Mobile.Core
{
    public static class Extensions
    {
        public static int CurrentLanguage = 1;

        public static MauiAppBuilder ConfigureMobileCore(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.ConfigurePages();
            builder.Services.AddServicesCore();
            return builder;
        }
    }
}