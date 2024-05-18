using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Customers;

public interface ICustomerRepository
{
    Task AddAsync(Customer customer, CancellationToken token = default);
    Task<bool> EmailExistsAsync(Email email, CancellationToken token = default);
    Task<bool> CpfExistsAsync(Cpf cpf, CancellationToken token = default);
    Task<Customer?> GetByIdAsync(Guid id, CancellationToken token = default);
    void Update(Customer customer);
    void Remove(Customer customer);
}
