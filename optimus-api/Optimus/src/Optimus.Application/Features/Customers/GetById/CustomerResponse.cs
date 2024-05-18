namespace Optimus.Application.Features.Customers.GetById;

public sealed record CustomerResponse(
    Guid Id,
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments);