namespace GPSMobile.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PinInfowindowView : Label
    {
        public PinInfowindowView(string text = "")
        {
            InitializeComponent();

            Text = text;
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                var lenght = text.Trim().Length;
                if (lenght >= 10)
                {
                    WidthRequest = (text.Trim().Length * 8.5);
                }
                else if (lenght <= 5)
                {
                    WidthRequest = (text.Trim().Length * 15);
                }
                else
                {
                    WidthRequest = (text.Trim().Length * 9);
                }
            }
            else
            {
                WidthRequest = -1;
            }
        }
    }
}