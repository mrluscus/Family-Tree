using FamilyTree.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace FamilyTree.Web
{
    public class Startup
    {
        private static ILogger<Startup> _logger = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services
                .AddDbContext<FamilyTreeDbContext>(options => options.UseNpgsql(connectionString), ServiceLifetime.Transient, ServiceLifetime.Transient)
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var provider = services.BuildServiceProvider();

            _logger = provider.GetService<ILogger<Startup>>();
            _logger.LogInformation("Application started");

            try
            {
                //Apply database migrations. (It will create DB if not exist)
                using (var dbCnt = provider.GetService<FamilyTreeDbContext>())
                {
                    dbCnt.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Migration error");
                throw;
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}