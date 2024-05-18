using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Products;

namespace Optimus.Application.Features.Products.Remove;

internal sealed class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand, Result>
{
    public RemoveProductCommandHandler(IProductRepository repository, IUnitOfWork transaction)
    {
        _repository = repository;
        _transaction = transaction;
    }

    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result> Handle(RemoveProductCommand request, CancellationToken token = default)
    {
        var product = await _repository.GetByIdAsync(request.Id, token);

        if (product is null)
        {
            return Result.Fail(ProductErrors.NotFound);
        }

        _repository.Remove(product);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok();
    }
}
