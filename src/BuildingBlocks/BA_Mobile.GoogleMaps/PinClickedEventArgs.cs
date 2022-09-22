﻿
namespace BA_Mobile.GoogleMaps
{
    public sealed class PinClickedEventArgs : EventArgs
    {
        public bool Handled { get; set; } = false;
        public Pin Pin { get; }

        public PinClickedEventArgs(Pin pin)
        {
            this.Pin = pin;
        }
    }
}
