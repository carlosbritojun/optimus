namespace Optimus.Api.Controllers.Products.V1;

public sealed record ProductListResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice);
