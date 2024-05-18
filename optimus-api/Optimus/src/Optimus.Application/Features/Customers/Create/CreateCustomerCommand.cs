using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Customers.Create;

public sealed record CreateCustomerCommand(
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments) : IRequest<Result<Guid>>;