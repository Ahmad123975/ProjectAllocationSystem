using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure_Service.DI
{
    public static class InfrastructureDIConfiguration
    {
        public static IServiceCollection InfrastructureServicesDIConfiguration(this IServiceCollection services, IConfiguration configuration) => services;
    }
}
