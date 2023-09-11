namespace UsingMediatrCQRS
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMediatrDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
            return services;
        }
    }
}
