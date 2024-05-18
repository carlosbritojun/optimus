using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Products.Create;

public sealed record CreateProductCommand(
    string Name, 
    int QuantityInStock, 
    decimal CostPrice, 
    decimal SalePrice, 
    string? Comments) : IRequest<Result<Guid>>;
