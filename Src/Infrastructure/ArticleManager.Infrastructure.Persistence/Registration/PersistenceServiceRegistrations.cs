
using ArticleManager.Infrastructure.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArticleManager.Infrastructure.Persistence.Registration
{
    public static class PersistenceServiceRegistrations
    {
        public static IServiceCollection ConfigurePersistenceServiceRegistrations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("ArticleManagerConnectionString")));



            return services;
        }
    }
}
