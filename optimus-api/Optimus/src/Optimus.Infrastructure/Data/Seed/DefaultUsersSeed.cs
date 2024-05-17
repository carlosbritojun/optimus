using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Users;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Seed;

internal static class DefaultUsersSeed
{
    private static readonly User[] _defaultUsers = [
        new (Guid.NewGuid(), new Email("admin@optimus.com"), EProfile.Administrator, new Password("1234")),
        new (Guid.NewGuid(), new Email("operator@optimus.com"), EProfile.Administrator, new Password("1234"))
    ];

    public static void SeedDefaultUsers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(_defaultUsers);
    }
}
