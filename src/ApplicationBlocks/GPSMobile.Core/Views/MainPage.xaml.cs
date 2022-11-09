using BA_Mobile.GoogleMaps;

namespace GPSMobile.Core.Views
{
    public partial class MainPage : ContentPage
    {
        private const int ClusterItemsCount = 50;
        private const double Extent = 0.2;

        private readonly Position currentPosition = new Position(52.225665764, 21.003833318);

        private readonly Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            googleMap.UiSettings.ZoomControlsEnabled = false;
            googleMap.IsUseCluster = true;
            googleMap.IsTrafficEnabled = false;

            googleMap.ClusterOptions.EnableBuckets = true;
            googleMap.ClusterOptions.Algorithm = ClusterAlgorithm.GridBased;
            googleMap.UiSettings.MapToolbarEnabled = false;
            googleMap.UiSettings.ZoomControlsEnabled = false;
            googleMap.UiSettings.MyLocationButtonEnabled = false;
            googleMap.UiSettings.RotateGesturesEnabled = false;
            googleMap.CameraIdled += GoogleMap_CameraIdled;
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                googleMap.ClusterOptions.RendererImage = BitmapDescriptorFactory.FromResource("ic_cluster.png");
            }
            googleMap.MoveToRegion(MapSpan.FromCenterAndRadius(currentPosition, Distance.FromMeters(100)));
        }

        /// <summary>
        /// sự kiện khi di chuyển map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoogleMap_CameraIdled(object sender, CameraIdledEventArgs e)
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                //googleMap.Cluster();
            }
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            for (var i = 0; i <= ClusterItemsCount; i++)
            {
                var lat = currentPosition.Latitude + Extent * GetRandomNumber(-1.0, 1.0);
                var lng = currentPosition.Longitude + Extent * GetRandomNumber(-1.0, 1.0);

                googleMap.ClusteredPins.Add(new Pin()
                {
                    Position = new Position(lat, lng),
                    Label = $"Item {i}",
                    Tag = $"Item {i}",
                    Anchor = new Point(0.5, 0.5),
                    Icon = BitmapDescriptorFactory.FromResource("taxi4_blue.png"),
                    Rotation = (float)(GetRandom(1, 7) * 45)
                });
                googleMap.ClusteredPins.Add(new Pin()
                {
                    Position = new Position(lat, lng),
                    Label = "89A16705" + "Plate" + i,
                    Icon = BitmapDescriptorFactory.FromView(new PinInfowindowView("89A16705" + i)),
                    Tag = "89A16705" + "Plate" + i
                });
            }

            googleMap.Cluster();
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private int GetRandom(int minimum, int maximum)
        {
            return random.Next() * (maximum - minimum) + minimum;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            for (var i = 0; i <= ClusterItemsCount; i++)
            {
                var lat = currentPosition.Latitude + Extent * GetRandomNumber(-1.0, 1.0);
                var lng = currentPosition.Longitude + Extent * GetRandomNumber(-1.0, 1.0);

                googleMap.ClusteredPins.Add(new Pin()
                {
                    Position = new Position(lat, lng),
                    Label = $"Item {i}",
                    Tag = $"Item {i}",
                    Anchor = new Point(0.5, 0.5),
                    Icon = BitmapDescriptorFactory.FromResource("taxi4_blue.png"),
                    Rotation = (float)(GetRandom(1, 7) * 45)
                });
                googleMap.ClusteredPins.Add(new Pin()
                {
                    Position = new Position(lat, lng),
                    Label = "89A16705" + "Plate" + i,
                    Icon = BitmapDescriptorFactory.FromView(new PinInfowindowView("89A16705" + i)),
                    Tag = "89A16705" + "Plate" + i
                });
            }

            googleMap.Cluster();
        }
    }
}