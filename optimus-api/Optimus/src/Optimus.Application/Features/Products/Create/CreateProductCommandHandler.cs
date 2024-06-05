using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;

namespace Optimus.Application.Features.Products.Create;

internal sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result<Guid>>
{
    public CreateProductCommandHandler(IProductRepository repository, IUnitOfWork transaction = null)
    {
        _repository = repository;
        _transaction = transaction;
    }

    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result<Guid>> Handle(CreateProductCommand request, CancellationToken token = default)
    {
        var name = new Name(request.Name);

        if (await _repository.NameExistsAsync(name))
        {
            return Result.Fail(ProductErrors.NameExists);
        }

        var product = Product.Create(
            Guid.NewGuid(),
            name,
            request.QuantityInStock,
            Money.Create(request.CostPrice),
            Money.Create(request.SalePrice),
            new Comments(request.Comments));

        await _repository.AddAsync(product, token);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok(product.Id);
    }
}
