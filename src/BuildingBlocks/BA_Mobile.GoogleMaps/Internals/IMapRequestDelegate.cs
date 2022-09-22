
namespace BA_Mobile.GoogleMaps.Internals
{
    public interface IMapRequestDelegate
    {
        void OnMoveToRegionRequest(MoveToRegionMessage m);
        void OnMoveCameraRequest(CameraUpdateMessage m);
    }
}
