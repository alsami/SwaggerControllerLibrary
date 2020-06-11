using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SwaggerControllerLibrary
{
    public class Startup
    {
        private const string SwaggerVersion = "v1";
        private const string ApiName = "Sample API";
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                .AddApiExplorer();
            
            services.AddRouting();


            
            services.AddSwaggerGen(options =>
                {
                    options.SwaggerDoc(ApiName, new OpenApiInfo
                    {
                        Version = SwaggerVersion,
                        Title = ApiName,
                    });
                }
            );
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseSwagger();
            app.UseSwaggerUI(action =>
            {
                action.SwaggerEndpoint($"/swagger/{SwaggerVersion}/swagger.json", ApiName);
            });
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapSwagger();
                endpoints.MapControllers();
            });
        }
    }
}
