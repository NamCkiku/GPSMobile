﻿using Google.Maps;

namespace BA_Mobile.GoogleMaps.iOS.Extensions
{
    internal static class BoundsExtensions
    {
        public static CoordinateBounds ToCoordinateBounds(this Bounds self)
        {
            return new CoordinateBounds(self.SouthWest.ToCoord(), self.NorthEast.ToCoord());
        }
    }
}

