using GPSMobile.Core;

namespace GPSMobile.BA
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .Configure();

            return builder.Build();
        }
    }
}