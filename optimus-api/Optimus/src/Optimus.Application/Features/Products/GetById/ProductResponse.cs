namespace Optimus.Application.Features.Products.GetById;

public sealed record ProductResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments,
    DateTime CreatedAt);
