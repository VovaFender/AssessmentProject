using APro.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APro.WebAPI.Core.Configuration
{
    public static class DependenciesConfig
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            services.AddDbContext<AssessmentDataContext>(
                opts => 
                    opts.UseNpgsql("Host=localhost; Port=5432; Database=AssessmentDB; Username=postgres; Password=admin;"));
    
            // services.AddScoped<IDataAccessProvider, DataAccessPostgreSqlProvider.DataAccessPostgreSqlProvider>
        }
    }
}