using System.Xml.Linq;

namespace Optimus.Api.Controllers.Products.V1;

public sealed record CreateProductRequest(
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments);