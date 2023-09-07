using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingMediatrCQRS.DataStore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDummyDataStore(this IServiceCollection services)
        {
            return services.AddSingleton<DummyDataStore>();
        }
    }
}
