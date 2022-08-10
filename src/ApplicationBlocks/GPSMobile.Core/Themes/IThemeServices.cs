//namespace GPSMobile.Core.Themes
//{
//    public interface IThemeServices
//    {
//        bool ChangeTheme(Theme themes);
//    }

//    public class ThemeServices : IThemeServices
//    {
//        private readonly IServiceProvider _provider;

//        public ThemeServices(IServiceProvider provider)
//        {
//            this._provider = provider;
//        }

//        public bool ChangeTheme(Theme themes)
//        {
//            Application.Current.Resources.MergedDictionaries.Clear();
//            //Application.Current.Resources.MergedDictionaries.Add(new Converters());
//            Application.Current.Resources.MergedDictionaries.Add(new Fonts());
//            switch (themes)
//            {
//                case Theme.Dark:
//                    var dark = _provider.GetService<ResourceDictionary>(Theme.Dark.ToString());
//                    Application.Current.Resources.MergedDictionaries.Add(dark);
//                    Application.Current.Resources.MergedDictionaries.Add(new Styles.Styles());
//                    Settings.CurrentTheme = Theme.Dark.ToString();
//                    return true;

//                case Theme.Light:
//                    var light = PrismApplicationBase.Current.Container.Resolve<ResourceDictionary>(Theme.Light.ToString());
//                    Application.Current.Resources.MergedDictionaries.Add(light);
//                    Application.Current.Resources.MergedDictionaries.Add(new Styles.Styles());
//                    Settings.CurrentTheme = Theme.Light.ToString();
//                    return true;

//                case Theme.Custom:
//                    var custom = PrismApplicationBase.Current.Container.Resolve<ResourceDictionary>(Theme.Custom.ToString());
//                    Application.Current.Resources.MergedDictionaries.Add(custom);
//                    Application.Current.Resources.MergedDictionaries.Add(new Styles.Styles());
//                    Settings.CurrentTheme = Theme.Custom.ToString();
//                    return true;

//                case Theme.Teacher:
//                    var teacher = PrismApplicationBase.Current.Container.Resolve<ResourceDictionary>(Theme.Teacher.ToString());
//                    Application.Current.Resources.MergedDictionaries.Add(teacher);
//                    Application.Current.Resources.MergedDictionaries.Add(new Styles.Styles());
//                    Settings.CurrentTheme = Theme.Teacher.ToString();
//                    return true;

//                default:
//                    return false;
//            }
//        }
//    }

//    public enum Theme
//    {
//        Dark,
//        Light,
//        Custom,
//        Teacher
//    }
//}