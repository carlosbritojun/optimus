using Optimus.Application.Features.Products.GetAll;

namespace Optimus.Api.Controllers.Products.V1.Models;

public sealed record ProductListApiResponse(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice)
{
    public static ProductListApiResponse From(ProductListResponse response) => new ProductListApiResponse(
        response.Id,
        response.Name,
        response.QuantityInStock,
        response.CostPrice,
        response.SalePrice);
}

