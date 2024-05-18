using Optimus.Application.Features.Customers.Create;

namespace Optimus.Api.Controllers.Customers.V1.Models;

public sealed record UpdateCustomerRequest(
    Guid Id,
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments)
{
    public UpdateCustomerCommand ToCommand() => new(Id, Name, Email, Cpf, Phone, Address, Comments);
}