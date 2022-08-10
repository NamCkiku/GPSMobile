namespace BA_Mobile.Core.Effects
{
    public class TintImageEffect : RoutingEffect
    {
        public const string GroupName = "BA_Mobile";
        public const string Name = "TintImageEffect";

        public Color TintColor { get; set; }

        public TintImageEffect() : base($"{GroupName}.{Name}")
        {
        }
    }
}