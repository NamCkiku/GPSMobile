namespace BA_Mobile.GoogleMaps.Behaviors
{
    public sealed class AnimateCameraRequest
    {
        internal AnimateCameraBehavior AnimateCameraBehavior { get; set; }

        public Task<AnimationStatus> AnimateCamera(CameraUpdate cameraUpdate, TimeSpan? duration = null)
        {
            if (AnimateCameraBehavior == null) return null;

            return AnimateCameraBehavior.AnimateCamera(cameraUpdate, duration);
        }
    }
}