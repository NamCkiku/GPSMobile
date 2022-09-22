
namespace BA_Mobile.GoogleMaps
{
    public sealed class PinDragEventArgs : EventArgs
    {
        public Pin Pin
        {
            get;
            private set;
        }

        internal PinDragEventArgs(Pin pin)
        {
            this.Pin = pin;
        }
    }
}

