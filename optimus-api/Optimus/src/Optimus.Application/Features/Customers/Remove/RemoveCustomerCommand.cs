using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Customers.Remove;

public sealed record RemoveCustomerCommand(Guid Id) : IRequest<Result>;
