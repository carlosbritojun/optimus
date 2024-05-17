namespace Optimus.Api.Controllers.Products.V1;

public sealed record ProductResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments,
    DateTime CreatedAt);
