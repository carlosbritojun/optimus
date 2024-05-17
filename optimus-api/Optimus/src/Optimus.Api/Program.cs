using Optimus.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);


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
}

app.UseAuthorization();

app.MapControllers();

app.Run();
