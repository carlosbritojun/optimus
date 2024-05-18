using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Products.Remove;

public sealed record RemoveProductCommand(Guid Id) : IRequest<Result>;
