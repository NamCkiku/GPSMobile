using BA_Mobile.GoogleMaps.Behaviors;
using System.Collections.ObjectModel;

namespace BA_Mobile.GoogleMaps.Behaviors
{
    public sealed class BindingCirclesBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<Circle>), typeof(BindingCirclesBehavior), default(ObservableCollection<Circle>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;

        public ObservableCollection<Circle> Value
        {
            get => (ObservableCollection<Circle>)GetValue(ValueProperty);
            private set => SetValue(ValuePropertyKey, value);
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.Circles as ObservableCollection<Circle>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}