namespace GPSMobile.Core.Pages
{
    public static class PagesExtensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.Services.AddSingleton<MainPage>();

            return builder;
        }
    }
}