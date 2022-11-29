using GPSMobile.Core.ViewModels;

namespace GPSMobile.Core.Views
{
    public static class ViewsExtensions
    {
        public static IContainerRegistry ConfigurePages(this IContainerRegistry container)
        {
            // main tabs of the app
            container.RegisterForNavigation<MainPage, MainPageViewModel>();

            return container;
        }
    }
}