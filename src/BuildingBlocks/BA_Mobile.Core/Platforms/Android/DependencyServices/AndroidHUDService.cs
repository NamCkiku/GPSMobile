using BA_Mobile.Core.Interfaces;

namespace BA_Mobile.Core.Platforms.Android.DependencyServices
{
    public class AndroidHUDService : IHUDProvider
    {
        public void DisplayProgress(string message)
        {
            AndroidHUD.AndHUD.Shared.Show(Platform.CurrentActivity, message);
        }

        public void Dismiss()
        {
            AndroidHUD.AndHUD.Shared.Dismiss(Platform.CurrentActivity);
        }
    }
}