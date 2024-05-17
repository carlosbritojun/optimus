using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Optimus.Api.Configuration;

public static class VersioningConfiguration
{
    public static void AddOptimusAPIVersioning(this IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerOptionsConfiguration>();

        services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
        }).AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
    }
}
