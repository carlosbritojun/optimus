using MediatR;
using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Entities.Products;
using Optimus.Infrastructure.Data;

namespace Optimus.Application.Features.Dashboard;

internal sealed class GenerateDashboardQueryHandler : IRequestHandler<GenerateDashboardQuery, DashboardResponse>
{
    public GenerateDashboardQueryHandler(OptimusDbContext context)
    {
        _context = context;
    }

    private readonly OptimusDbContext _context;

    public async Task<DashboardResponse> Handle(GenerateDashboardQuery request, CancellationToken token = default)
    {
        var totalOfCustomers = _context.Set<Customer>().Count();

        var totalOfProduts = _context.Set<Product>().Count();

        var productsTop10 = await GetProdutcsTop10();

        var productsWithoutStockOrZero = await GetProductsWithoutStockOrZero();

        return new DashboardResponse(
            totalOfProduts,
            totalOfCustomers,
            productsTop10,
            productsWithoutStockOrZero);
    }

    private async Task<IReadOnlyList<ProductsTop10Response>> GetProdutcsTop10()
    {
        return await _context
            .Set<Product>()
            .AsNoTracking()
            .Take(10)
            .Where(product => product.QuantityInStock > 0)
            .OrderByDescending(product => product.QuantityInStock)
            .Select(product => new ProductsTop10Response(
                product.Id,
                product.Name.Value,
                product.QuantityInStock))
            .ToListAsync();        
    }

    private async Task<IReadOnlyList<ProductsWithoutStockOrZero>> GetProductsWithoutStockOrZero()
    {
        return await _context
            .Set<Product>()
            .AsNoTracking()
            .Where(product => product.QuantityInStock <= 0)
            .OrderBy(product => product.QuantityInStock)
            .Select(product => new ProductsWithoutStockOrZero(
                product.Id,
                product.Name.Value,
                product.QuantityInStock))
            .ToListAsync();
    }
}
