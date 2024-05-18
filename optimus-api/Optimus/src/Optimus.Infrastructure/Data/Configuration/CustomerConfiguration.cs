using Bogus.Bson;
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
           .HasMaxLength(20)
           .HasConversion(cpf => cpf.Document, document => new Cpf(document));

        builder.Property(customer => customer.Email)
            .HasMaxLength(400)
            .HasConversion(email => email.Address, address => new Email(address));

        builder.Property(customer => customer.Name)
            .HasMaxLength(100)
            .HasConversion(name => name.Value, value => new Name(value));

        builder.Property(customer => customer.Phone)
           .HasMaxLength(50)
           .HasConversion(tel => tel.Value, value => new Phone(value));

        builder.Property(customer => customer.Address)
           .HasMaxLength(200)
           .HasConversion(address => address.Value, value => new Address(value));

        builder.Property(produto => produto.Comments)
            .HasMaxLength(500)
            .HasConversion(comments => comments.Value, value => new Comments(value));

        builder.HasIndex(customer => customer.Email).IsUnique();
        builder.HasIndex(customer => customer.Cpf).IsUnique();
        builder.HasIndex(customer => customer.Name);

    }

}
