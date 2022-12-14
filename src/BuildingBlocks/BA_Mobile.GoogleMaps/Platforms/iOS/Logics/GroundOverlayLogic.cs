using Google.Maps;
using BA_Mobile.GoogleMaps.Logics;
using NativeGroundOverlay = Google.Maps.GroundOverlay;
using BA_Mobile.GoogleMaps.iOS.Extensions;
using CoreGraphics;
using BA_Mobile.GoogleMaps.iOS.Factories;
using UIKit;

namespace BA_Mobile.GoogleMaps.Logics.iOS
{
    public class GroundOverlayLogic : DefaultGroundOverlayLogic<NativeGroundOverlay, MapView>
    {
        private readonly IImageFactory _imageFactory;
        
        protected override IList<GroundOverlay> GetItems(Map map) => map.GroundOverlays;

        public GroundOverlayLogic(IImageFactory imageFactory)
        {
            _imageFactory = imageFactory;
        }

        public override void Register(MapView oldNativeMap, Map oldMap, MapView newNativeMap, Map newMap, IElementHandler handler)
        {
            base.Register(oldNativeMap, oldMap, newNativeMap, newMap, handler);

            if (newNativeMap != null)
            {
                newNativeMap.OverlayTapped += OnOverlayTapped;
            }
        }

        public override void Unregister(MapView nativeMap, Map map)
        {
            if (nativeMap != null)
            {
                nativeMap.OverlayTapped -= OnOverlayTapped;
            }

            base.Unregister(nativeMap, map);
        }

        protected override NativeGroundOverlay CreateNativeItem(GroundOverlay outerItem)
        {
            var factory = _imageFactory ?? DefaultImageFactory.Instance;
            var nativeOverlay = NativeGroundOverlay.GetGroundOverlay(
                outerItem.Bounds.ToCoordinateBounds(), factory.ToUIImage(outerItem.Icon));
            nativeOverlay.Bearing = outerItem.Bearing;
            nativeOverlay.Opacity = 1 - outerItem.Transparency;
            nativeOverlay.Tappable = outerItem.IsClickable;
            nativeOverlay.ZIndex = outerItem.ZIndex;

            if (outerItem.Icon != null)
            {
                nativeOverlay.Icon = factory.ToUIImage(outerItem.Icon);
            }

            outerItem.NativeObject = nativeOverlay;
            nativeOverlay.Map = outerItem.IsVisible ? NativeMap : null;

            OnUpdateIconView(outerItem, nativeOverlay);

            return nativeOverlay;
        }

        protected override NativeGroundOverlay DeleteNativeItem(GroundOverlay outerItem)
        {
            var nativeOverlay = outerItem.NativeObject as NativeGroundOverlay;
            nativeOverlay.Map = null;

            return nativeOverlay;
        }

        void OnOverlayTapped(object sender, GMSOverlayEventEventArgs e)
        {
            var targetOuterItem = GetItems(Map).FirstOrDefault(
                outerItem => object.ReferenceEquals(outerItem.NativeObject, e.Overlay));
            targetOuterItem?.SendTap();
        }

        public override void OnUpdateBearing(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            nativeItem.Bearing = outerItem.Bearing;
        }

        public override void OnUpdateBounds(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            nativeItem.Bounds = outerItem.Bounds.ToCoordinateBounds();
        }

        public override void OnUpdateIcon(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            if (outerItem.Icon.Type == BitmapDescriptorType.View)
            {
                OnUpdateIconView(outerItem, nativeItem);
            }
            else
            {
                var factory = _imageFactory ?? DefaultImageFactory.Instance;
                nativeItem.Icon = factory.ToUIImage(outerItem.Icon);
            }
        }

        public override void OnUpdateIsClickable(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            nativeItem.Tappable = outerItem.IsClickable;
        }

        public override void OnUpdateTransparency(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            nativeItem.Opacity = 1f - outerItem.Transparency;
        }

        public override void OnUpdateZIndex(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            nativeItem.ZIndex = outerItem.ZIndex;
        }

        protected void OnUpdateIconView(GroundOverlay outerItem, NativeGroundOverlay nativeItem)
        {
            if (outerItem?.Icon?.Type == BitmapDescriptorType.View && outerItem?.Icon?.View != null)
            {
                NativeMap.InvokeOnMainThread(() =>
                {
                    //var iconView = outerItem.Icon.View;
                    //var nativeView = Utils.ConvertMauiToNative(iconView, new CGRect(0, 0, iconView.WidthRequest, iconView.HeightRequest), Handler);
                    //nativeView.BackgroundColor = UIColor.Clear;
                    ////nativeItem.GroundAnchor = new CGPoint(iconView.AnchorX, iconView.AnchorY);
                    //nativeItem.Icon = Utils.ConvertViewToImage(iconView, Handler);

                    //// Would have been way cooler to do this instead, but surprisingly, we can't do this on Android:
                    //// nativeItem.IconView = nativeView;
                });
            }
        }
    }
}

