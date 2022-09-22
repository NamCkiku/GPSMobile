using BA_Mobile.GoogleMaps;
using BA_Mobile.GoogleMaps.iOS.Factories;
using System.Collections.Concurrent;
using UIKit;

namespace GPSMobile.Core.Platforms.iOS
{
    public class CachingImageFactory : IImageFactory
    {
        private readonly ConcurrentDictionary<string, UIImage> _cache = new();

        public UIImage ToUIImage(BitmapDescriptor descriptor)
        {
            var defaultFactory = DefaultImageFactory.Instance;

            if (!string.IsNullOrEmpty(descriptor.Id))
            {
                var cacheEntry = _cache.GetOrAdd(descriptor.Id, _ => defaultFactory.ToUIImage(descriptor));
                return cacheEntry;
            }

            return defaultFactory.ToUIImage(descriptor);
        }
    }
}