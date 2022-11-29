namespace BA_Mobile.Core.Interfaces
{
    public static class Extensions
    {
        public static MauiAppBuilder ConfigureService(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDialogPopupService, DialogPopupService>();

#if ANDROID
            builder.Services.AddSingleton<IHUDProvider, BA_Mobile.Core.Platforms.Android.DependencyServices.AndroidHUDService>(); 
            
#elif IOS
            builder.Services.AddSingleton<IHUDProvider, BA_Mobile.Core.Platforms.iOS.DependencyServices.iOSHUDService>();   
#endif
            return builder;
        }
    }
}