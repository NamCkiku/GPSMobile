using BA_Mobile.Core.ViewModels;

namespace BA_Mobile.Core.Views
{
    public static class Extensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // main tabs of the app
            //builder.Services.AddSingleton<MainPage>();
            builder.Services.RegisterForNavigation<NavigationPage>("NavigationPage");
            builder.Services.RegisterForNavigation<DialogBase, DialogBaseViewModel>();
            builder.Services.RegisterForNavigation<ConfirmPage, ConfirmPageViewModel>();
            return builder;
        }
    }
}