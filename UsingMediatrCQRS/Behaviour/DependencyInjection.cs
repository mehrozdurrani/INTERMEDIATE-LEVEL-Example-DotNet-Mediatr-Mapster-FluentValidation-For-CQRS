using System.Reflection;
using FluentValidation;
using MediatR;
using UsingMediatrCQRS.Commands;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Behaviour
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<
                IPipelineBehavior<RegisterPersonCommand, Person>,
                ValidationBehaviour
            >();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
