using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Optimus.Api.Configuration;

public sealed class SwaggerOptionsConfiguration : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    public SwaggerOptionsConfiguration(IApiVersionDescriptionProvider provider)
    {
        _provider = provider;
    }

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
        }
    }
    private OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
    {
        var info = new OpenApiInfo
        {
            Title = "Optimus API",
            Version = description.ApiVersion.ToString(),
            Description = "Descrição da API do Optimus"
        };

        if (description.IsDeprecated)
        {
            info.Description += " - Esta versão de API está depreciada";
        }

        return info;
    }
}
