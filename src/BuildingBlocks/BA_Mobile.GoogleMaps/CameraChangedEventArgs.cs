
namespace BA_Mobile.GoogleMaps
{
    public sealed class CameraChangedEventArgs : EventArgs
    {
        public CameraPosition Position
        {
            get;
        }

        public CameraChangedEventArgs(CameraPosition position)
        {
            Position = position;
        }
    }
}