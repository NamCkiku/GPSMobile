using Google.Maps;

namespace BA_Mobile.GoogleMaps.iOS.Extensions
{
    public static class EnumerableExtensions
    {
        public static MutablePath ToMutablePath(this IEnumerable<Position> self)
        {
            var path = new MutablePath();
            foreach (var p in self)
            {
                path.AddLatLon(p.Latitude, p.Longitude);
            }
            return path;
        }
    }
}