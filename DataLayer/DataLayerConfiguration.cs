using DataLayer.Repositories;
using DataLayer.Scopes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public static class DataLayerConfiguration
    {
        public static void AddDataLayerContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataBaseContext>(options => options.UseNpgsql(connectionString));
            services.AddScoped<AbstractUserScope, DataBaseContext>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
