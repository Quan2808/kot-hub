using Infrastructure.Data.Contexts;
using KOT_Hub.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace KOT_Hub;

public class Startup(IConfiguration configuration)
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure DbContext with SQL Server
        services.AddDbContext<KOTHubDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Add controllers to the service collection
        services.AddControllers(options => { options.Conventions.Add(new ApiPrefixConvention("api")); });

        // Add logging services
        services.AddLogging();

        // Add services for API exploration and Swagger/OpenAPI
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "KOT Hub - Volta Live Schedule API",
                Version = "v1",
                Description = "API for Volta Live schedule application"
            });
        });
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        // Enable Swagger and Swagger UI in development environment
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Volta Live Schedule API v1"); });
        }
        else
        {
            //  Enable Swagger in production for testing 
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Volta Live Schedule API v1"); });
        }

        // Redirect HTTP requests to HTTPS
        app.UseHttpsRedirection();

        // Enable authorization middleware
        // app.UseAuthorization();

        // Map controller endpoints
        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}