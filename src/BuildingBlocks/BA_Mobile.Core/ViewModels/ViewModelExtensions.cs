namespace BA_Mobile.Core.ViewModels
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            //builder.Services.AddSingleton<SubscriptionsViewModel>();

            return builder;
        }
    }
}