
namespace BA_Mobile.GoogleMaps.Internals
{
    internal sealed class TakeSnapshotMessage
    {
        public Action<Stream> OnSnapshot { get; }

        public TakeSnapshotMessage(Action<Stream> onSnapshot)
        {
            OnSnapshot = onSnapshot;
        }
    }
}