using BA_Mobile.Core.Views;
using Mopups.Services;

namespace BA_Mobile.Core.Interfaces
{
    public interface IDialogPopupService
    {
        Task<bool> ShowConfirmationDialogAsync(string title, string message);

        void ShowMessageDialogAsync(string title, string message);
    }

    public class DialogPopupService : IDialogPopupService
    {
        public async Task<bool> ShowConfirmationDialogAsync(string title, string message)
        {
            var confirmationDialog = new ConfirmPage(title, message);
            await MopupService.Instance.PushAsync(confirmationDialog);
            var result = await confirmationDialog.GetResult();
            await MopupService.Instance.PopAllAsync();
            return (bool)result;
        }

        public async void ShowMessageDialogAsync(string title, string message)
        {
            var messageDialog = new MessagePage(title, message);
            await MopupService.Instance.PushAsync(messageDialog);
        }
    }
}