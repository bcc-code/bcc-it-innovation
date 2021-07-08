using Bcc.Auth.Stores.RavenDb;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Configuration
{
    public static class RavenConfigurationExtensions
    {
        public static IServiceCollection AddRavenDb(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("Raven").Get<RavenConfig>();
            services.AddSingleton(config);
            services.AddSingleton(c =>
            {
                var config = c.GetRequiredService<RavenConfig>();
                var store = new RavenStore(config);
                return store;
            });
            return services;
        }
    }
}
