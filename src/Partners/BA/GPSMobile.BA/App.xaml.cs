using GPSMobile.BA.Resources.Themes;
using GPSMobile.Core.Pages;
using GPSMobile.Core.Resources.Styles;

namespace GPSMobile.BA
{
    public partial class App : Application
    {
        public App(MainPage page)
        {
            Resources.MergedDictionaries.Add(new LightTheme());
            Resources.MergedDictionaries.Add(new Styles());
            InitializeComponent();
            MainPage = page;
        }
    }
}