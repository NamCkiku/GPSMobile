namespace GPSMobile.Core.Views
{
    public static class ViewsExtensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.Services.AddSingleton<MainPage>();

            return builder;
        }
    }
}