using Optimus.Application.Features.Reports.Products;

namespace Optimus.Api.Controllers.Reports.V1.Models;

public sealed record ProductReportApiReponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice)
{
    public static ProductReportApiReponse From(ProductReportResponse response) => new(
        response.Id,
        response.Name,
        response.QuantityInStock,
        response.CostPrice,
        response.SalePrice);
}
