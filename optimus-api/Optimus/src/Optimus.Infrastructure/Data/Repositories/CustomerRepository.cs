using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Repositories;

public sealed class CustomerRepository : ICustomerRepository
{
    public CustomerRepository(OptimusDbContext context)
    {
        _context = context;
    }

    private readonly OptimusDbContext _context;

    public async Task AddAsync(Customer customer, CancellationToken token = default)
    {
        await _context.Set<Customer>().AddAsync(customer, token);
    }

    public async Task<bool> CpfExistsAsync(Cpf cpf, CancellationToken token = default)
    {
        return await _context.Set<Customer>()
            .AsNoTracking() 
            .AnyAsync(customer => customer.Cpf == cpf);
    }

    public async Task<bool> EmailExistsAsync(Email email, CancellationToken token = default)
    {
        return await _context.Set<Customer>()
            .AsNoTracking()
            .AnyAsync(customer => customer.Email == email);
    }

    public async Task<Customer?> GetByIdAsync(Guid id, CancellationToken token = default)
    {
        return await _context.Set<Customer>()
            .FirstOrDefaultAsync(customer => customer.Id == id, token);
    }

    public void Update(Customer customer)
    {
        _context.Set<Customer>().Update(customer);
    }

    public void Remove(Customer customer)
    {
        _context.Set<Customer>().Remove(customer);
    }
}
