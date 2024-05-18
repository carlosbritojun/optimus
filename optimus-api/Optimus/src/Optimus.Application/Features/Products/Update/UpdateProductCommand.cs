using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Products.Update;

public sealed record UpdateProductCommand(
    Guid Id,
    string Name,
    int QuantityInStock,
    decimal CostPrice,
    decimal SalePrice,
    string? Comments) : IRequest<Result>;