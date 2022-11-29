using BA_Mobile.Core.ViewModels;

namespace BA_Mobile.Core.Views
{
    public static class Extensions
    {
        public static IContainerRegistry ConfigurePagesCore(this IContainerRegistry container)
        {
            container.RegisterForNavigation<NavigationPage>();
            container.RegisterForNavigation<DialogBase, DialogBaseViewModel>();
            container.RegisterForNavigation<ConfirmPage, ConfirmPageViewModel>();
            return container;
        }
    }
}