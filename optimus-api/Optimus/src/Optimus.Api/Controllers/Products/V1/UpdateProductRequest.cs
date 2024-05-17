namespace Optimus.Api.Controllers.Products.V1;

public sealed record UpdateProductRequest(
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments);