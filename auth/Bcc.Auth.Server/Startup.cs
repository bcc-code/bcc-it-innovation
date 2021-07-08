using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bcc.Auth.Server.Services;
using Bcc.Auth.Server.Stores;
using Bcc.Auth.Stores;
using Bcc.Auth.Stores.RavenDb;
using Duende.IdentityServer.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Bcc.Auth.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRavenDb(Configuration);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bcc.Auth.Server", Version = "v1" });
            });

            services.AddScoped<IClientStore, ClientStore>();
            services.AddScoped<IResourceStore, ResourceStore>();
            services.AddScoped<IApiResourceRepository, RavenApiResourceRepository>();
            services.AddScoped<IClientRepository, RavenClientRepository>();
            services.AddIdentityServer(o =>
            {
            });

            services.AddHostedService<InitializationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bcc.Auth.Server v1"));
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseIdentityServer();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
