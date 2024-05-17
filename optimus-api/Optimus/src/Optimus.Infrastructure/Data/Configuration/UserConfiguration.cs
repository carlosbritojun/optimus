using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimus.Domain.Entities.Users;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Configuration;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Email)
            .HasMaxLength(200)
            .HasConversion(email => email.Address, address => new Email(address));

        builder.Property(user => user.Password)
            .HasMaxLength(100)
            .HasConversion(password => password.Value, value => new Password(value));

        builder.HasIndex(usuario => usuario.Email).IsUnique();
    }

}
