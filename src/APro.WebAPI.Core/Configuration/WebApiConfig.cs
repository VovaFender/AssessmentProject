using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace APro.WebAPI.Core.Configuration
{
    public static class WebApiConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            DependenciesConfig.ConfigureDependencies(services);            
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseMvc(ConfigureRoutes);
        }

        private static void ConfigureRoutes(IRouteBuilder routes)
        {    
            // routes.MapRoute(
            //     name: "default",
            //     template: "api/{controller}/{action?}/{id?}"
            // );
        }
    }
}