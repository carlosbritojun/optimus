using FluentResults;
using MediatR;
using Optimus.Domain.Entities.Products;

namespace Optimus.Application.Features.Products.GetById;

internal sealed class GetByIdProductCommandHandler : IRequestHandler<GetByIdProductQuery, Result<ProductResponse>>
{
    public GetByIdProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public async Task<Result<ProductResponse>> Handle(GetByIdProductQuery request, CancellationToken token = default)
    {
        var product = await _repository.GetByIdAsync(request.Id, default);

        if (product is null)
        {
            return Result.Fail(ProductErrors.NotFound);
        }

        return Result.Ok(new ProductResponse(
            product.Id,
            product.Name.Value,
            product.QuantityInStock,
            product.CostPrice.Value,
            product.SalePrice.Value,
            product.Comments?.Value,
            product.CreatedAt));
    }
}
