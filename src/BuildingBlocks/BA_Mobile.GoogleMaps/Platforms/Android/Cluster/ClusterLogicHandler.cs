using Android.Gms.Maps.Utils.Clustering;
using BA_Mobile.GoogleMaps.Platforms.Android.Logics;

namespace BA_Mobile.GoogleMaps.Android
{
    public class ClusterLogicHandler : Java.Lang.Object,
        ClusterManager.IOnClusterClickListener,
        ClusterManager.IOnClusterItemClickListener,
        ClusterManager.IOnClusterInfoWindowClickListener,
        ClusterManager.IOnClusterItemInfoWindowClickListener
    {
        private Map map;
        private ClusterManager clusterManager;
        private ClusterLogic logic;

        public ClusterLogicHandler(Map map, ClusterManager manager, ClusterLogic logic)
        {
            this.map = map;
            clusterManager = manager;
            this.logic = logic;
        }

        public bool OnClusterClick(ICluster cluster)
        {
            var pins = GetClusterPins(cluster);
            var clusterPosition = new Position(cluster.Position.Latitude, cluster.Position.Longitude);
            return map.SendClusterClicked(cluster.Items.Count, pins, clusterPosition);
        }

        private List<Pin> GetClusterPins(ICluster cluster)
        {
            var pins = new List<Pin>();
            foreach (var item in cluster.Items)
            {
                var clusterItem = (ClusteredMarker)item;
                pins.Add(logic.LookupPin(clusterItem));
            }

            return pins;
        }

        public bool OnClusterItemClick(Java.Lang.Object nativeItemObj)
        {
            var targetPin = logic.LookupPin(nativeItemObj as ClusteredMarker);

            targetPin?.SendTap();

            if (targetPin != null)
            {
                if (!ReferenceEquals(targetPin, map.SelectedPin))
                    map.SelectedPin = targetPin;
                map.SendPinClicked(targetPin);
            }

            return true;
        }

        public void OnClusterInfoWindowClick(ICluster cluster)
        {
        }

        public void OnClusterItemInfoWindowClick(Java.Lang.Object nativeItemObj)
        {
            var targetPin = logic.LookupPin(nativeItemObj as ClusteredMarker);

            targetPin?.SendTap();

            if (targetPin != null)
            {
                map.SendInfoWindowClicked(targetPin);
            }
        }
    }
}