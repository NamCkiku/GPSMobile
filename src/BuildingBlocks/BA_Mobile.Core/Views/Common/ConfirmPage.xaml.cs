using BA_Mobile.Core.ViewModels;

namespace BA_Mobile.Core.Views
{
    public partial class ConfirmPage : DialogBase
    {
        private ConfirmPageViewModel vm;
        private string _message;
        private string _title;

        public ConfirmPage(string title, string message)
        {
            InitializeComponent();
            BindingContext = new ConfirmPageViewModel();
            _message = message;
            _title = title;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            vm = (ConfirmPageViewModel)BindingContext;
            vm.Message = _message;
            vm.Title = _title;
        }
    }
}