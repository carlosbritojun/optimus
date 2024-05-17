using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Configuration;

internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customers");

        builder.HasKey(customer => customer.Id);

        builder.Property(customer => customer.Cpf)
           .HasMaxLength(400)
           .HasConversion(cpf => cpf.Document, document => new Cpf(document));

        builder.Property(customer => customer.Email)
            .HasMaxLength(400)
            .HasConversion(email => email.Address, address => new Email(address));

        builder.Property(customer => customer.Name)
            .HasMaxLength(100)
            .HasConversion(name => name.Value, valor => new Name(valor));

        builder.Property(customer => customer.Phone)
           .HasMaxLength(100)
           .HasConversion(tel => tel.Value, valor => new Phone(valor));

        builder.Property(produto => produto.Comments)
            .HasMaxLength(500)
            .HasConversion(comments => comments.Value, valor => new Comments(valor));

        builder.OwnsOne(customer => customer.Address);

        builder.HasIndex(customer => customer.Email).IsUnique();
        builder.HasIndex(customer => customer.Cpf).IsUnique();
        builder.HasIndex(customer => customer.Name);

    }

}
