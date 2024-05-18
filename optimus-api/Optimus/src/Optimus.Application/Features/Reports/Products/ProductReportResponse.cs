namespace Optimus.Application.Features.Reports.Products;

public sealed record ProductReportResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice);
