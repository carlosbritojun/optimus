namespace Optimus.Api.Controllers.Dashboard.V1;

public sealed record DashboardResponse(
    int ProductsCount,
    int CustomersCount,
    List<ProductsTop10Response> ProductsTop10,
    List<ProductWithoutStockOrZero> ProductsWithoutStockOrZero);


public sealed record ProductsTop10Response(
    Guid Id,
    string Name,
    int QuantityInStock);

public sealed record ProductWithoutStockOrZero(
    Guid Id,
    string Name,
    int QuantityInStock);
