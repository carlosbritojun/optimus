using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Customers.Create;

public sealed record UpdateCustomerCommand(
    Guid Id,
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments) : IRequest<Result>;