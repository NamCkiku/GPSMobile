using Prism.Commands;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BA_Mobile.Core.ViewModels
{
    public class DialogBaseViewModel : ExtendedBindableObject
    {
        public TaskCompletionSource<object> Proccess;
        public ICommand DestroyCommand { get; }

        public DialogBaseViewModel()
        {
            DestroyCommand = new DelegateCommand(DestroyPage);
            Proccess = new TaskCompletionSource<object>();
        }

        private string title;
        public virtual string Title { get => title; set => SetProperty(ref title, value); }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private void DestroyPage()
        {
            Proccess.SetResult(false);
        }

        public Task<object> GetProccess()
        {
            return Proccess.Task;
        }
    }
}