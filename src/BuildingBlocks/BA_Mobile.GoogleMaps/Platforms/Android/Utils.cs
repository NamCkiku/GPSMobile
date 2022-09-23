// Original code from https://github.com/javiholcman/Wapps.Forms.Map/
// Cacheing implemented by Gadzair

using Android.Graphics;
using Android.Views;
using Microsoft.Maui.Platform;

namespace BA_Mobile.GoogleMaps.Android
{
    class Utils
    {
        /// <summary>
        /// convert from dp to pixels
        /// </summary>
        /// <param name="dp">Dp.</param>
        public static int DpToPx(float dp)
        {
            var metrics = global::Android.App.Application.Context.Resources.DisplayMetrics;
            return (int)(dp * metrics.Density);
        }

        /// <summary>
        /// convert from px to dp
        /// </summary>
        /// <param name="px">Px.</param>
        public static float PxToDp(int px)
        {
            var metrics = global::Android.App.Application.Context.Resources.DisplayMetrics;
            return px / metrics.Density;
        }

        public static Task<global::Android.Views.View> ConvertMauiToNative(Microsoft.Maui.Controls.View view, IElementHandler handler)
        {
            return Task.Run(() =>
            {
                var nativeView = view.ToPlatform(handler.MauiContext);
                return nativeView;
            });
        }

        public static Bitmap ConvertViewToBitmap(global::Android.Views.View v)
        {
            try
            {
                v.Measure(global::Android.Views.View.MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified), global::Android.Views.View.MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified));
                v.Layout(0, 0, v.MeasuredWidth, v.MeasuredHeight);
                Bitmap bitmap = Bitmap.CreateBitmap(v.MeasuredWidth, v.MeasuredHeight, Bitmap.Config.Argb8888);
                Canvas canvas = new Canvas(bitmap);
                v.Draw(canvas);
                return bitmap;
            }
            catch (System.Exception)
            {
                return Bitmap.CreateBitmap(v.MeasuredWidth, v.MeasuredHeight, Bitmap.Config.Argb8888);
            }
        }

        public static Task<global::Android.Gms.Maps.Model.BitmapDescriptor> ConvertViewToBitmapDescriptor(global::Android.Views.View v)
        {
            return Task.Run(() =>
            {
                var bmp = ConvertViewToBitmap(v);
                var img = global::Android.Gms.Maps.Model.BitmapDescriptorFactory.FromBitmap(bmp);
                return img;
            });
        }

        public static global::Android.Widget.FrameLayout AddViewOnFrameLayout(global::Android.Views.View view, int width, int height)
        {
            var layout = new global::Android.Widget.FrameLayout(view.Context);
            layout.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            view.LayoutParameters = new global::Android.Widget.FrameLayout.LayoutParams(width, height);
            layout.AddView(view);
            return layout;
        }
    }
}