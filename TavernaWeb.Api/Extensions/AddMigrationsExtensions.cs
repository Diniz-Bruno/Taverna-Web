using Microsoft.EntityFrameworkCore;
using TavernaWeb.Persistence.Context;

namespace TavernaWeb.Api.Extensions;

public static class AddMigrationsExtensions
{
    public static IServiceCollection AddMigrations(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}