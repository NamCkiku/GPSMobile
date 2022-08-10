using GPSMobile.Service.IService;
using GPSMobile.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GPSMobile.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesGPSMobile(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}