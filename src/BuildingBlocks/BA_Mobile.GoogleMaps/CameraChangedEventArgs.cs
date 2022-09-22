
namespace BA_Mobile.GoogleMaps
{
    public sealed class CameraChangedEventArgs : EventArgs
    {
        public CameraPosition Position
        {
            get;
        }

        internal CameraChangedEventArgs(CameraPosition position)
        {
            Position = position;
        }
    }
}