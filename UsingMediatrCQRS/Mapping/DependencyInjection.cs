using System.Reflection;
using Mapster;
using MapsterMapper;

namespace UsingMediatrCQRS.Mapping
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomMapping(this IServiceCollection services)
        {
            // Scaning all the Assembly for IRegister components
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            // Adding Service
            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            return services;
        }
    }
}
