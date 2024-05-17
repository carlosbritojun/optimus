using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optimus.Infrastructure.Data;

namespace Optimus.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddPersistence(services, configuration);
        return services;
    }

    private static IServiceCollection AddPersistence(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database") ??
                       throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<OptimusDbContext>(options =>
        {
            options
                .UseNpgsql(connectionString)
                .EnableDetailedErrors()
                .UseSnakeCaseNamingConvention();
        });

        return services;
    }


}
