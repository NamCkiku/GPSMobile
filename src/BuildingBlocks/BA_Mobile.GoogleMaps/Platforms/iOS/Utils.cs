// Original code from https://github.com/javiholcman/Wapps.Forms.Map/
// Cacheing implemented by Gadzair

using UIKit;
using CoreGraphics;
using System.Security.Cryptography;
using System.Collections.Concurrent;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

namespace BA_Mobile.GoogleMaps
{
    public static class Utils
    {
        public static UIView ConvertMauiToNative(View view, CGRect size, IElementHandler elementHandler)
        {
            return view.ToPlatform(elementHandler.MauiContext);
        }

        private static LinkedList<string> lruTracker = new LinkedList<string>();
        private static ConcurrentDictionary<string, UIImage> cache = new ConcurrentDictionary<string, UIImage>();

        public static UIImage ConvertViewToImage(Pin vehicle, IElementHandler elementHandler)
        {
            UIImage img = new UIImage();
            var iconView = vehicle.Icon.View;
            var size = new CGRect(0, 0, iconView.WidthRequest, iconView.HeightRequest);
            var nativeView = Utils.ConvertMauiToNative(iconView, size, elementHandler);
            nativeView.BackgroundColor = iconView.BackgroundColor.ToPlatform();
            img = nativeView.AsImage();

            return img;
        }

        public static UIImage AsImage(this UIView view)

        {
            UIGraphics.BeginImageContextWithOptions(view.Bounds.Size, false, 0);

            view.Layer.RenderInContext(UIGraphics.GetCurrentContext());

            var img = UIGraphics.GetImageFromCurrentImageContext();

            UIGraphics.EndImageContext();

            return img;
        }
    }
}

