using Mopups.Services;
using System.Windows.Input;

namespace BA_Mobile.Core.ViewModels
{
    public class MessagePageViewModel : ExtendedBindableObject
    {
        public ICommand DestroyCommand { get; }

        public MessagePageViewModel()
        {
            DestroyCommand = new DelegateCommand(DestroyPage);
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string title;
        public string Title { get => title; set => SetProperty(ref title, value); }

        private async void DestroyPage()
        {
            await MopupService.Instance.PopAllAsync();
        }
    }
}