using BA_Mobile.Core.Interfaces;

namespace BA_Mobile.Core.ViewModels
{
    public class ViewModelBaseServices
    {
        public ViewModelBaseServices(
            INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService,
            IDialogViewRegistry dialogRegistry,
            IHUDProvider hUDProvider)
        {
            NavigationService = navigationService;
            PageDialogs = pageDialogs;
            Dialogs = dialogService;
            DialogRegistry = dialogRegistry;
            _hUDProvider = hUDProvider;
        }

        public INavigationService NavigationService { get; }
        public IPageDialogService PageDialogs { get; }
        public IDialogService Dialogs { get; }
        public IDialogViewRegistry DialogRegistry { get; }
        public IHUDProvider _hUDProvider { get; }
    }
}