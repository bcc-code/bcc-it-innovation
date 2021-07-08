using Bcc.Auth.Server.Stores;
using Bcc.Auth.Stores;
using Duende.IdentityServer.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bcc.Auth.Server.Services
{
    public class InitializationService : IHostedService
    {
        private readonly IServiceProvider _services;

        public InitializationService(IServiceProvider services)
        {
            _services = services;
        }

        public async Task InitializeAsync()
        {
            using (var scope = _services.CreateScope())
            {
                var clients = scope.ServiceProvider.GetRequiredService<IClientRepository>();
                var apiResources = scope.ServiceProvider.GetRequiredService<IApiResourceRepository>();

                await clients.AddClientAsync(new Duende.IdentityServer.Models.Client
                {
                    ClientName = "Test Client",
                    ClientId = "test-client"
                });

                await apiResources.AddApiResourceAsync(new ApiResource
                {
                    Name = "API-1",
                    Enabled = true,
                    DisplayName = "API One"
                });
            }
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Run in background
            _ = Task.Run(async () => await InitializeAsync());
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
