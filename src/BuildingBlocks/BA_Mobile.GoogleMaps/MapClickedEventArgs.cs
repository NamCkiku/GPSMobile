
namespace BA_Mobile.GoogleMaps
{
    public sealed class MapClickedEventArgs : EventArgs
    {
        public Position Point { get; }

        public MapClickedEventArgs(Position point)
        {
            this.Point = point;
        }
    }
}
