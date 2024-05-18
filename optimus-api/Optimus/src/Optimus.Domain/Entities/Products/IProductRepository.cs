using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Products;

public interface IProductRepository
{
    Task AddAsync(Product product, CancellationToken tojen = default);
    Task<bool> NameExistsAsync(Name name, CancellationToken token = default);
}
