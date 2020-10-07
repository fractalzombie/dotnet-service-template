using ApplicationLayer.User;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationLayer
{
    public static class ApplicationLayerConfiguration
    {
        public static void AddApplicationLayerContext(this IServiceCollection services)
        {
            // services.AddDbContext<DataBaseContext>(options => options.UseNpgsql(connectionString));
            services.AddScoped<IUserService, UserService>();
        }
    }
}
