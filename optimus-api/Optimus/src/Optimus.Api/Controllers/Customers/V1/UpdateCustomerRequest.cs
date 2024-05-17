namespace Optimus.Api.Controllers.Customers.V1;

public sealed record UpdateCustomerRequest(
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments);