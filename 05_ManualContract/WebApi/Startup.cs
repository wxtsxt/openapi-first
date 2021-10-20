using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// using Microsoft.OpenApi.Models;
using NodaTime;
using NodaTime.Serialization.SystemTextJson;

namespace WebApiFromTemplate
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
            services.AddControllers()
                .AddJsonOptions(opt => opt.JsonSerializerOptions.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb))
                ;
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "openapi_first", Version = "v1" });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.yaml", "openapi_first v1");
                c.RoutePrefix = "";
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/swagger/v1/swagger.yaml", async context =>
                {
                    await context.Response.WriteAsync(await File.ReadAllTextAsync(@"..\OpenAPIs\contract-first-swagger.yaml"));
                });
                endpoints.MapGet("/swagger/v1/contract-problem-details.openapi.json", async context =>
                {
                    await context.Response.WriteAsync(await File.ReadAllTextAsync(@"..\OpenAPIs\contract-problem-details.openapi.json"));
                });

                endpoints.MapControllers();
            });
        }
    }
}
