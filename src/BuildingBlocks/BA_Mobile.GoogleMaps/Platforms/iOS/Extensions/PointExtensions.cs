using CoreGraphics;

namespace BA_Mobile.GoogleMaps.iOS.Extensions
{
    public static class PointExtensions
    {
        public static CGPoint ToCGPoint(this Point self)
        {
            return new CGPoint((float)self.X, (float)self.Y);
        }
    }
}

