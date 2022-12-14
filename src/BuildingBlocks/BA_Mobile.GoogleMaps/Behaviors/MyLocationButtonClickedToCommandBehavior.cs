namespace BA_Mobile.GoogleMaps.Behaviors
{
    
    public sealed class MyLocationButtonClickedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.MyLocationButtonClicked += OnMyLocationButtonClicked;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.MyLocationButtonClicked -= OnMyLocationButtonClicked;
        }

        private void OnMyLocationButtonClicked(object sender, MyLocationButtonClickedEventArgs myLocationButtonClickedEventArgs)
        {
            Command?.Execute(myLocationButtonClickedEventArgs);
        }
    }
}