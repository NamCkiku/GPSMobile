using BA_Mobile.GoogleMaps;

namespace GPSMobile.Core.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            googleMap.InitialCameraUpdate = CameraUpdateFactory.NewPositionZoom(new Position(20.9735, 105.847), 14);
            googleMap.UiSettings.ZoomGesturesEnabled = true;
            googleMap.UiSettings.ZoomControlsEnabled = false;
            googleMap.UiSettings.RotateGesturesEnabled = false;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }
    }
}