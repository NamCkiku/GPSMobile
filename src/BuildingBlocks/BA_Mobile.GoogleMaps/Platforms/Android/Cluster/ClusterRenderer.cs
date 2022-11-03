using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Gms.Maps.Utils.Clustering;
using Android.Gms.Maps.Utils.Clustering.View;
using BA_Mobile.GoogleMaps.Android.Factories;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using System.Collections;
using NativeBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;

namespace BA_Mobile.GoogleMaps.Android
{
    public class ClusterRenderer : DefaultClusterRenderer
    {
        private readonly Map map;
        private readonly Dictionary<string, NativeBitmapDescriptor> disabledBucketsCache;
        private readonly Dictionary<string, NativeBitmapDescriptor> enabledBucketsCache;
        private static int MIN_CLUSTER_SIZE = 4;
        public ClusterRenderer(Context context,
            Map map,
            GoogleMap nativeMap,
            ClusterManager manager)
            : base(context, nativeMap, manager)
        {
            this.map = map;
            MinClusterSize = map.ClusterOptions.MinimumClusterSize;
            disabledBucketsCache = new Dictionary<string, NativeBitmapDescriptor>();
            enabledBucketsCache = new Dictionary<string, NativeBitmapDescriptor>();
        }
        protected override bool ShouldRenderAsCluster(ICluster cluster)
        {
            return cluster.Size > MIN_CLUSTER_SIZE * 2;
        }
        public void SetUpdatePositionMarker(ClusteredMarker clusteredMarker)
        {
            var marker = GetMarker(clusteredMarker);
            if (marker == null) return;
            marker.Position = new LatLng(clusteredMarker.Position.Latitude, clusteredMarker.Position.Longitude);
        }

        public void SetUpdateRotationMarker(ClusteredMarker clusteredMarker)
        {
            var marker = GetMarker(clusteredMarker);
            if (marker == null) return;
            marker.Rotation = clusteredMarker.Rotation;
        }
        public void SetUpdateMarker(ClusteredMarker clusteredMarker)
        {
            var marker = GetMarker(clusteredMarker);
            if (marker == null) return;
            marker.Position = new LatLng(clusteredMarker.Position.Latitude, clusteredMarker.Position.Longitude);
            marker.Title = clusteredMarker.Title;
            marker.Snippet = clusteredMarker.Snippet;
            marker.Draggable = clusteredMarker.Draggable;
            marker.Rotation = clusteredMarker.Rotation;
            marker.SetAnchor(clusteredMarker.AnchorX, clusteredMarker.AnchorY);
            marker.SetInfoWindowAnchor(clusteredMarker.InfoWindowAnchorX, clusteredMarker.InfoWindowAnchorY);
            marker.Flat = clusteredMarker.Flat;
            marker.Alpha = clusteredMarker.Alpha;
            marker.SetIcon(clusteredMarker.Icon);
        }
        public override void OnClustersChanged(ICollection clusters)
        {
            base.OnClustersChanged(clusters);
        }
        protected override bool ShouldRender(ICollection oldClusters, ICollection newClusters)
        {
            return base.ShouldRender(oldClusters, newClusters);
        }

        protected override void OnBeforeClusterRendered(ICluster cluster, MarkerOptions options)
        {
            NativeBitmapDescriptor icon;
            if (map.ClusterOptions.RendererCallback != null)
            {
                var descriptorFromCallback =
                    map.ClusterOptions.RendererCallback(map.ClusterOptions.EnableBuckets ?
                        GetClusterText(cluster) : cluster.Size.ToString());
                icon = GetIcon(cluster, descriptorFromCallback);
                options.SetIcon(icon);
            }
            else if (map.ClusterOptions.RendererImage != null)
            {
                icon = GetIcon(cluster, map.ClusterOptions.RendererImage);
                options.SetIcon(icon);
            }
            else
                base.OnBeforeClusterRendered(cluster, options);
        }

        private NativeBitmapDescriptor GetIcon(ICluster cluster, BitmapDescriptor descriptor)
        {
            var bitmapDescriptorFactory = DefaultBitmapDescriptorFactory.Instance;
            var icon = GetFromIconCache(cluster);
            if (icon == null)
            {
                icon = bitmapDescriptorFactory.ToNative(descriptor);
                AddToIconCache(cluster, icon);
            }
            return icon;
        }

        private NativeBitmapDescriptor GetFromIconCache(ICluster cluster)
        {
            NativeBitmapDescriptor bitmapDescriptor;
            var clusterText = GetClusterText(cluster);
            if (map.ClusterOptions.EnableBuckets)
                enabledBucketsCache.TryGetValue(clusterText, out bitmapDescriptor);
            else
                disabledBucketsCache.TryGetValue(clusterText, out bitmapDescriptor);
            return bitmapDescriptor;
        }

        private void AddToIconCache(ICluster cluster, NativeBitmapDescriptor icon)
        {
            var clusterText = GetClusterText(cluster);
            if (map.ClusterOptions.EnableBuckets)
                enabledBucketsCache.Add(clusterText, icon);
            else
                disabledBucketsCache.Add(clusterText, icon);
        }

        protected override void OnBeforeClusterItemRendered(Java.Lang.Object marker, MarkerOptions options)
        {
            var clusteredMarker = marker as ClusteredMarker;

            options.SetTitle(clusteredMarker.Title)
                .SetSnippet(clusteredMarker.Snippet)
                .SetSnippet(clusteredMarker.Snippet)
                .Draggable(clusteredMarker.Draggable)
                .SetRotation(clusteredMarker.Rotation)
                .Anchor(clusteredMarker.AnchorX, clusteredMarker.AnchorY)
                .InfoWindowAnchor(clusteredMarker.InfoWindowAnchorX, clusteredMarker.InfoWindowAnchorY)
                .SetAlpha(clusteredMarker.Alpha)
                .Flat(clusteredMarker.Flat);

            if (clusteredMarker.Icon != null)
                options.SetIcon(clusteredMarker.Icon);

            base.OnBeforeClusterItemRendered(marker, options);
        }

        protected override int GetBucket(ICluster cluster)
        {
            var size = cluster.Size / 2;
            if (size <= map.ClusterOptions.Buckets[0])
                return size;
            return map.ClusterOptions.Buckets[BucketIndexForSize(size)];
        }

        protected override int GetColor(int size)
        {
            return map.ClusterOptions.BucketColors[BucketIndexForSize(size)].ToAndroid();
        }

        private string GetClusterText(ICluster cluster)
        {
            string result;
            var size = cluster.Size / 2;

            if (map.ClusterOptions.EnableBuckets)
            {
                var buckets = map.ClusterOptions.Buckets;
                var bucketIndex = BucketIndexForSize(size);
                result = size.ToString();
            }
            else
                result = size.ToString();

            return result;
        }

        private int BucketIndexForSize(int size)
        {
            uint index = 0;
            var buckets = map.ClusterOptions.Buckets;

            while (index + 1 < buckets.Length && buckets[index + 1] <= size)
                ++index;

            return (int)index;
        }
    }
}