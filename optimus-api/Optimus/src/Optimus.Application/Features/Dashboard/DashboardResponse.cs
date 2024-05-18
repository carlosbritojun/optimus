namespace Optimus.Application.Features.Dashboard;

public sealed record DashboardResponse(
    int TotalOfProducts,
    int TotalOfCustomers,
    IReadOnlyList<ProductsTop10Response> ProductsTop10,
    IReadOnlyList<ProductsWithoutStockOrZero> ProductsWithoutStockOrZero);


public sealed record ProductsTop10Response(
    Guid Id,
    string Name,
    int QuantityInStock);

public sealed record ProductsWithoutStockOrZero(
    Guid Id,
    string Name,
    int QuantityInStock);
