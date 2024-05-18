using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Abstractions;
using Optimus.Infrastructure.Data.Seed;

namespace Optimus.Infrastructure.Data;

public class OptimusDbContext : DbContext, IUnitOfWork
{
    public OptimusDbContext(DbContextOptions<OptimusDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OptimusDbContext).Assembly);
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}
