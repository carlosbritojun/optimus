using Microsoft.EntityFrameworkCore;
using Optimus.Api.Middlewares;
using Optimus.Infrastructure.Data;

namespace Optimus.Api.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app, bool dropDatabase = false)
    {
        using var scope = app.ApplicationServices.CreateScope();
        using var db = scope.ServiceProvider.GetRequiredService<OptimusDbContext>();

        if (dropDatabase)
        {
            db.Database.EnsureDeleted();
        }

        db.Database.Migrate();
    }

    public static void UseCustomExceptionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
