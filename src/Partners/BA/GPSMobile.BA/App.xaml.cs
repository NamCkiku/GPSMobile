using BA_Mobile.Utilities.Constant;
using BA_Mobile.Utilities.Enums;
using GPSMobile.BA.Resources.Themes;
using GPSMobile.Core.Resources.Styles;
using GPSMobile.Core.Views;

namespace GPSMobile.BA
{
    public partial class App : Application
    {
        public App(MainPage page)
        {
            ServerConfig.ApiEndpointTypes = ApiEndpointTypes.ServerThat;
            Resources.MergedDictionaries.Add(new LightTheme());
            Resources.MergedDictionaries.Add(new Styles());
            InitializeComponent();
            MainPage = page;
        }
    }
}