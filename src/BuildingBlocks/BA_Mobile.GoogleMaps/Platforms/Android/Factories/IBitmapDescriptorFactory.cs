using AndroidBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;

namespace BA_Mobile.GoogleMaps.Android.Factories
{
    public interface IBitmapDescriptorFactory
    {
        AndroidBitmapDescriptor ToNative(BitmapDescriptor descriptor);
    }
}