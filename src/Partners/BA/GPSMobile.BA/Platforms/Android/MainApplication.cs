using Android.App;
using Android.Runtime;

namespace GPSMobile.BA
{
    [Application]
    [MetaData("com.google.android.maps.v2.API_KEY",
             Value = BA_Mobile.Utilities.Constant.Config.GoogleMapKeyAndroid)]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}