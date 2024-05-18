using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Entities.Products;
using Optimus.Infrastructure.Data;
using Optimus.Infrastructure.Data.Repositories;

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

        services
            .AddScoped<ICustomerRepository, CustomerRepository>()
            .AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<OptimusDbContext>());

        return services;
    }
}
