using BA_Mobile.Service.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace BA_Mobile.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesCore(this IServiceCollection services)
        {
            services.AddScoped<IRequestProvider, RequestProvider>();
            services.AddScoped<IMapper, MapperUtility>();

            return services;
        }
    }
}