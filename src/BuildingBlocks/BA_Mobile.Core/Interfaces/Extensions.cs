namespace BA_Mobile.Core.Interfaces
{
    public static class Extensions
    {
        public static MauiAppBuilder ConfigureService(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDialogPopupService, DialogPopupService>();
            return builder;
        }
    }
}