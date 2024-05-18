using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Products;

public interface IProductRepository
{
    Task AddAsync(Product product, CancellationToken tojen = default);
    Task<bool> NameExistsAsync(Name name, CancellationToken token = default);
    Task<bool> NameExistsAsync(Guid excludedId, Name name, CancellationToken token = default);
    Task<Product?> GetByIdAsync(Guid id, CancellationToken token = default);

    void Update(Product product);
}
