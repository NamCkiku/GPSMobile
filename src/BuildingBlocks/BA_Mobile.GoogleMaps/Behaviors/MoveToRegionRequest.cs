namespace BA_Mobile.GoogleMaps.Behaviors
{
    public sealed class MoveToRegionRequest
    {
        internal event EventHandler<MoveToRegionRequestedEventArgs> MoveToRegionRequested;

        public void MoveToRegion(MapSpan mapSpan, bool animated = true)
        {
            MoveToRegionRequested?.Invoke(this, new MoveToRegionRequestedEventArgs(mapSpan, animated));
        }
    }
}