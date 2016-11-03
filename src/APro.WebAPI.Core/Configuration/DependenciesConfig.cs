using System.IO;
using APro.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APro.WebAPI.Core.Configuration
{
    public static class DependenciesConfig
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            var connectionStringsConfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("connectionStrings.json")
                .Build();
            
            services.AddDbContext<AssessmentDataContext>(
                opts => opts.UseNpgsql(connectionStringsConfig.GetConnectionString("AssessmentDB")));            
        }
    }
}