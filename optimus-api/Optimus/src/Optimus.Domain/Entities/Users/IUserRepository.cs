using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Users;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(Email email, CancellationToken token = default);
}
