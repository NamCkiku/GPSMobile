namespace BA_Mobile.Core.Styles
{
    public partial class Styles
    {
        public static readonly Style ButtonPrimary = CreateStyle<Button>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.PrimaryColor)
        .Set(Button.TextColorProperty, AppColors.WhiteColor);

        public static readonly Style AcceptButton = CreateStyle<Button>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.PrimaryColor)
        .Set(Button.TextColorProperty, AppColors.WhiteColor)
        .Set(Button.TextProperty, "ĐỒNG Ý");

        public static readonly Style CancelButton = CreateStyle<Button>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.WhiteColor)
        .Set(Button.TextColorProperty, AppColors.PrimaryColor)
        .Set(Button.BorderColorProperty, AppColors.TextPlaceHolderColor)
        .Set(Button.TextProperty, "HỦY BỎ");

        public static readonly Style DangerousButton = CreateStyle<Button>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.RedColor)
        .Set(Button.TextColorProperty, AppColors.PrimaryColor);

        public static readonly Style SlimLine = CreateStyle<BoxView>()
        .Set(BoxView.HeightRequestProperty, 1)
        .Set(VisualElement.BackgroundColorProperty, AppColors.TextPlaceHolderColor);

        public static readonly Style BoldText = CreateStyle<Label>()
        .Set(Label.FontAttributesProperty, FontAttributes.Bold)
        .Set(Label.FontFamilyProperty, FontNames.RobotoBold);
    }

    public static partial class Styles
    {
        public static Style CreateStyle<T>()
        {
            return new Style(typeof(T));
        }

        public static Style BaseOn(this Style style, Style basedOn)
        {
            style.BasedOn = basedOn;
            return style;
        }

        public static Style Set(this Style style, BindableProperty property, object value)
        {
            style.Setters.Add(new Setter
            {
                Property = property,
                Value = value
            });
            return style;
        }

        public static Style BindTrigger(this Style style, Binding binding, object value, params (BindableProperty p, object value)[] setters)
        {
            var dataTrigger = new DataTrigger(style.TargetType)
            {
                Binding = binding,
                Value = value
            };

            for (int i = 0; i < setters.Length; i++)
            {
                dataTrigger.Setters.Add(new Setter
                {
                    Property = setters[i].p,
                    Value = setters[i].value
                });
            }

            style.Triggers.Add(dataTrigger);

            return style;
        }
    }
}