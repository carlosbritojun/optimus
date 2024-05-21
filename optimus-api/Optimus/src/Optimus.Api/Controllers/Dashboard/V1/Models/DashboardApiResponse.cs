using Optimus.Application.Features.Dashboard;

namespace Optimus.Api.Controllers.Dashboard.V1.Models;

public sealed record DashboardApiResponse(
    int TotalOfProducts,
    int TotalOfCustomers,
    IReadOnlyList<ProductsApiTop10Response> ProductsTop10,
    IReadOnlyList<ProductsApiWithoutStockOrZero> ProductsWithoutStockOrZero)
{
    public static DashboardApiResponse From(DashboardResponse response) => new DashboardApiResponse(
        response.TotalOfProducts,
        response.TotalOfCustomers,
        response.ProductsTop10.Select(p => new ProductsApiTop10Response(p.Id, p.Name, p.QuantityInStock)).ToList(),
        response.ProductsWithoutStockOrZero.Select(p => new ProductsApiWithoutStockOrZero(p.Id, p.Name, p.QuantityInStock)).ToList());
}


public sealed record ProductsApiTop10Response(
    Guid Id,
    string Name,
    int QuantityInStock);

public sealed record ProductsApiWithoutStockOrZero(
    Guid Id,
    string Name,
    int QuantityInStock);