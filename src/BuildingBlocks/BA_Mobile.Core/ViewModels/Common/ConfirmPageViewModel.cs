using Prism.Commands;
using System.Windows.Input;

namespace BA_Mobile.Core.ViewModels
{
    public class ConfirmPageViewModel : DialogBaseViewModel
    {
        public ICommand AgreeCommand { get; }

        public ConfirmPageViewModel()
        {
            AgreeCommand = new DelegateCommand(Agree);
        }

        private void Agree()
        {
            Proccess.SetResult(true);
        }
    }
}