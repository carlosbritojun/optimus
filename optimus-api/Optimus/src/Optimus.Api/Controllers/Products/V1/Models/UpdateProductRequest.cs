using Optimus.Application.Features.Products.Update;

namespace Optimus.Api.Controllers.Products.V1.Models;

public sealed record UpdateProductRequest(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments)
{
    public UpdateProductCommand ToCommand() => new(Id, Name, QuantityInStock, CostPrice, SalePrice, Comments);
}