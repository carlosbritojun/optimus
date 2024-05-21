using MediatR;
using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Products;
using Optimus.Infrastructure.Data;

namespace Optimus.Application.Features.Products.GetAll;

internal sealed class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IReadOnlyList<ProductListResponse>>
{
    public GetAllProductsQueryHandler(OptimusDbContext context)
    {
        _context = context;
    }

    private readonly OptimusDbContext _context;

    public async Task<IReadOnlyList<ProductListResponse>> Handle(GetAllProductsQuery request, CancellationToken token = default)
    {
        return await _context.Set<Product>()
            .AsNoTracking()
            .OrderBy(product => product.Name)
            .Select(product => new ProductListResponse(
                product.Id,
                product.Name.Value,
                product.QuantityInStock,
                product.CostPrice.Value,
                product.SalePrice.Value))
            .ToListAsync();
    }
}
