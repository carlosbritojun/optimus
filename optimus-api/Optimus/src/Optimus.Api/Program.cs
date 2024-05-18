using Optimus.Api.Configuration;
using Optimus.Api.Extensions;
using Optimus.Application;
using Optimus.Infrastructure;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddValidators()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptimusAPIVersioning();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var apis = app.DescribeApiVersions();
        foreach (var api in apis)
        {
            options.SwaggerEndpoint($"/swagger/{api.GroupName}/swagger.json", api.GroupName.ToUpperInvariant());
        }
    });

    //app.ApplyMigrations();
}

app.UseCustomExceptionHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
