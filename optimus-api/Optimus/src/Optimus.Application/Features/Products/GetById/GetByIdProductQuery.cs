using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Products.GetById;

public sealed record GetByIdProductQuery(Guid Id) : IRequest<Result<ProductResponse>>;
