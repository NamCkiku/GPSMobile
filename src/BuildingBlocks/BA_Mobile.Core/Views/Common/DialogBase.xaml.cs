using BA_Mobile.Core.ViewModels;
using Mopups.Pages;

namespace BA_Mobile.Core.Views
{
    public partial class DialogBase : PopupPage
    {
        private DialogBaseViewModel vm;

        public DialogBase()
        {
            InitializeComponent();
            BindingContext = new DialogBaseViewModel();
            this.CloseWhenBackgroundIsClicked = false;
        }

        #region Bindable Properties

        public static readonly BindableProperty ActionsPlaceHolderProperty
            = BindableProperty.Create
              (nameof(ActionsPlaceHolder), typeof(View), typeof(DialogBase));

        public View ActionsPlaceHolder
        {
            get { return (View)GetValue(ActionsPlaceHolderProperty); }
            set { SetValue(ActionsPlaceHolderProperty, value); }
        }

        #endregion Bindable Properties

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public virtual Task<object> GetResult()
        {
            vm = (DialogBaseViewModel)BindingContext;
            return vm.GetProccess();
        }
    }
}