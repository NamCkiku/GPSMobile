
namespace BA_Mobile.GoogleMaps
{
    public sealed class MyLocationButtonClickedEventArgs : EventArgs
    {
        public bool Handled { get; set; } = false;

        public MyLocationButtonClickedEventArgs()
        {
        }
    }
}
