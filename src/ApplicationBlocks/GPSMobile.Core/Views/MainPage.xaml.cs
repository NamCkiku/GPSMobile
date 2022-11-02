using BA_Mobile.GoogleMaps;
using GPSMobile.Core.ViewModels;

namespace GPSMobile.Core.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel vm;

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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            vm = (MainPageViewModel)BindingContext;
            await Task.Delay(1000); // workaround for #30 [Android]Map.Pins.Add doesn't work when page OnAppearing
            vm.GetListRoute();
        }
    }
}