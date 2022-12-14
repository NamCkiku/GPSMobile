using Android.Gms.Maps.Model;

namespace BA_Mobile.GoogleMaps.Android.Extensions
{
    public static class LatLngExtensions
    {
        public static Position ToPosition(this LatLng self)
        {
            return new Position(self.Latitude, self.Longitude);
        }
    }
}

