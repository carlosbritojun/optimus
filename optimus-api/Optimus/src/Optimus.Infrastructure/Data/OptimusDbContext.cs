using Microsoft.EntityFrameworkCore;
using Optimus.Infrastructure.Data.Seed;

namespace Optimus.Infrastructure.Data;

public class OptimusDbContext : DbContext
{
    public OptimusDbContext(DbContextOptions<OptimusDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OptimusDbContext).Assembly);
        modelBuilder.SeedDefaultUsers();
        base.OnModelCreating(modelBuilder);
    }
}
