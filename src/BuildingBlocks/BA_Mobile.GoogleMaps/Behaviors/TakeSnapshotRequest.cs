namespace BA_Mobile.GoogleMaps.Behaviors
{
    public sealed class TakeSnapshotRequest
    {
        internal TakeSnapshotBehavior TakeSnapshotBehavior { get; set; }

        public Task<Stream> TakeSnapshot()
        {
            if (TakeSnapshotBehavior == null) throw new InvalidOperationException("Not binding to TakeSnapshotBehavior.");

            return TakeSnapshotBehavior.TakeSnapshot();
        }
    }
}