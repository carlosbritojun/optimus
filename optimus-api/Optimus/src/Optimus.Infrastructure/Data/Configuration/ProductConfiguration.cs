using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Configuration;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");

        builder.HasKey(product => product.Id);

        builder.Property(product => product.Name)
            .HasMaxLength(100)
            .HasConversion(name => name.Value, value => new Name(value));

        builder.Property(product => product.Comments)
            .HasMaxLength(500)
            .HasConversion(comments => comments.Value, value => new Comments(value));

        builder.Property(product => product.CostPrice)
            .HasConversion(custo => custo.Value, valor => Money.Create(valor));

        builder.Property(product => product.SalePrice)
            .HasConversion(sale => sale.Value, value => Money.Create(value));

        builder.HasIndex(product => product.Name);

        builder.Property<uint>("Version").IsRowVersion();
    }

}
