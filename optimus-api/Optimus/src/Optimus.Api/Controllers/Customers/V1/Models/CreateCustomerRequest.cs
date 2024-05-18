using Optimus.Application.Features.Customers.Create;

namespace Optimus.Api.Controllers.Customers.V1.Models;

public sealed record CreateCustomerRequest(
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments)
{
    public CreateCustomerCommand ToCommand() => new(Name, Email, Cpf, Phone, Address, Comments);
}