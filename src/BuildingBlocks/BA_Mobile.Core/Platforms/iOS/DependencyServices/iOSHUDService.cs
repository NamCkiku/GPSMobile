using BA_Mobile.Core.Interfaces;
using BigTed;

namespace BA_Mobile.Core.Platforms.iOS.DependencyServices
{
    public class iOSHUDService : IHUDProvider
    {
        public void DisplayProgress(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                BTProgressHUD.Show(null, -1, MaskType.Black);
            }
            else
            {
                BTProgressHUD.Show(message, -1, MaskType.Black);
            }
        }

        public void Dismiss()
        {
            BTProgressHUD.Dismiss();
        }
    }
}