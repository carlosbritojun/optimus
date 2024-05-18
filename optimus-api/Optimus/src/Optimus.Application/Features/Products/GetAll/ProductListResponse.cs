namespace Optimus.Application.Features.Products.GetAll;

public sealed record ProductListResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice);
