using System.Runtime.InteropServices;
using UIKit;

namespace BA_Mobile.GoogleMaps.iOS.Extensions
{
    public static class ThicknessExtension
    {
        public static UIEdgeInsets ToUIEdgeInsets(this Thickness self)
        {
            return new UIEdgeInsets((NFloat)self.Top, (NFloat)self.Left, (NFloat)self.Bottom, (NFloat)self.Right);
        }
    }
}
