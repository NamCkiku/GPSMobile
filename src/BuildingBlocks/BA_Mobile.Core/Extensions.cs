using BA_Mobile.Core.Constant;
using BA_Mobile.Core.ViewModels;
using BA_Mobile.Core.Views;
using BA_Mobile.Service;

namespace BA_Mobile.Core
{
    public static class Extensions
    {
        public static int CurrentLanguage = Settings.CurrentLanguage;

        public static MauiAppBuilder ConfigureMobileCore(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.ConfigurePages().ConfigureViewModels();
            builder.Services.AddServicesCore();
            return builder;
        }
    }
}