using BA_Mobile.Core.ViewModels;

namespace BA_Mobile.Core.Views
{
    public partial class MessagePage : DialogBase
    {
        private MessagePageViewModel vm;
        private string _message;
        private string _title;

        public MessagePage(string title, string message)
        {
            InitializeComponent();
            BindingContext = new MessagePageViewModel();
            _message = message;
            _title = title;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            vm = (MessagePageViewModel)BindingContext;
            vm.Message = _message;
            vm.Title = _title;
        }
    }
}