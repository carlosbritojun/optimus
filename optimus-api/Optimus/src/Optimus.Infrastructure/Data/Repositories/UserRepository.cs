using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Users;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Repositories;

public class UserRepository : IUserRepository
{
    public UserRepository(OptimusDbContext context)
    {
        _context = context;
    }

    private readonly OptimusDbContext _context;

    public async Task<User?> GetByEmailAsync(Email email, CancellationToken token = default)
    {
        return await _context.Set<User>()
            .FirstOrDefaultAsync(user => user.Email == email, token);
    }
}
