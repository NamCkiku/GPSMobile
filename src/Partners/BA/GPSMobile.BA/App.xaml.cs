using BA_Mobile.Core.Resources.Styles;
using BA_Mobile.Utilities.Constant;
using BA_Mobile.Utilities.Enums;
using GPSMobile.BA.Resources.Themes;

namespace GPSMobile.BA
{
    public partial class App : Application
    {
        public App()
        {
            ServerConfig.ApiEndpointTypes = ApiEndpointTypes.ServerThat;
            Resources.MergedDictionaries.Add(new LightTheme());
            Resources.MergedDictionaries.Add(new Styles());
            InitializeComponent();
        }
    }
}