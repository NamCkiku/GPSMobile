
namespace BA_Mobile.GoogleMaps
{
    public sealed class CameraMoveStartedEventArgs : EventArgs
    {
        public bool IsGesture { get; }

        internal CameraMoveStartedEventArgs(bool isGesture)
        {
            IsGesture = isGesture;
        }
    }
}