
namespace BA_Mobile.GoogleMaps
{
    public sealed class CameraIdledEventArgs : EventArgs
    {
        public CameraPosition Position { get;  }

        public CameraIdledEventArgs(CameraPosition position)
        {
            this.Position = position;
        }
    }
}