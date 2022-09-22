
namespace BA_Mobile.GoogleMaps
{
    public sealed class MapLongClickedEventArgs : EventArgs
    {
        public Position Point { get; }

        public MapLongClickedEventArgs(Position point)
        {
            this.Point = point;
        }
    }
}