using Optimus.Application.Features.Products.Create;

namespace Optimus.Api.Controllers.Products.V1.Models;

public sealed record CreateProductRequest(
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments)
{
    public CreateProductCommand ToCommand() => new(Name, QuantityInStock, CostPrice, SalePrice, Comments);
}