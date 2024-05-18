using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Products.GetAll;

public sealed record GetAllProductsQuery : IRequest<IReadOnlyList<ProductListResponse>>;
