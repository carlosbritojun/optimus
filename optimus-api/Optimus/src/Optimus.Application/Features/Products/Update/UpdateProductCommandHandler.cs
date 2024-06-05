using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;

namespace Optimus.Application.Features.Products.Update;

internal sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
{
    public UpdateProductCommandHandler(IProductRepository repository, IUnitOfWork transaction)
    {
        _repository = repository;
        _transaction = transaction;
    }

    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result> Handle(UpdateProductCommand request, CancellationToken token = default)
    {
        var product = await _repository.GetByIdAsync(request.Id, default);

        if (product is null)
        {
            return Result.Fail(ProductErrors.NotFound);
        }

        var name = new Name(request.Name);

        if (await _repository.NameExistsAsync(request.Id, name))
        {
            return Result.Fail(ProductErrors.NameExists);
        }

        product.ChangeBasicInfo(name, new Comments(request.Comments));
        product.ChangePrices(Money.Create(request.CostPrice), Money.Create(request.SalePrice));
        product.ChangeStock(request.QuantityInStock);

        _repository.Update(product);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok();
    }
}
