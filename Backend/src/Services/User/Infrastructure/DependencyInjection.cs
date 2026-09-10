using Microsoft.EntityFrameworkCore;
using User.Infrastructure.Contexts;

namespace User.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WriteUserContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("WriteDatabase")));

        services.AddDbContext<ReadUserContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("ReadDatabase")));

        return services;
    }
}