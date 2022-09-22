using UIKit;

namespace BA_Mobile.GoogleMaps.iOS.Factories
{
    public interface IImageFactory
    {
        UIImage ToUIImage(BitmapDescriptor descriptor);
    }
}