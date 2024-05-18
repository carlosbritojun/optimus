using Optimus.Application.Features.Products.GetById;

namespace Optimus.Api.Controllers.Products.V1.Models;

public sealed record ProductApiResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments,
    DateTime CreatedAt)
{
    public static ProductApiResponse From(ProductResponse response) => new ProductApiResponse(
        response.Id,
        response.Name,
        response.QuantityInStock,
        response.CostPrice,
        response.SalePrice,
        response.Comments,
        response.CreatedAt);
}
