using BA_Mobile.GoogleMaps.Behaviors;
using System.Collections.ObjectModel;

namespace BA_Mobile.GoogleMaps.Behaviors
{
    public sealed class BindingPolygonsBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<Polygon>), typeof(BindingPolygonsBehavior), default(ObservableCollection<Polygon>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;

        public ObservableCollection<Polygon> Value
        {
            get => (ObservableCollection<Polygon>)GetValue(ValueProperty);
            private set => SetValue(ValuePropertyKey, value);
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.Polygons as ObservableCollection<Polygon>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}