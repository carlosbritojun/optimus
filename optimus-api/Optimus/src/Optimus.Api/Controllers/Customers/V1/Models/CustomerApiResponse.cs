using Optimus.Application.Features.Customers.GetById;

namespace Optimus.Api.Controllers.Customers.V1.Models;

public sealed record CustomerApiResponse(
    Guid Id,
    string Name,
    string Email,
    string Cpf,
    string Phone,
    string Address,
    string? Comments)
{
    public static CustomerApiResponse From(CustomerResponse response) => new CustomerApiResponse(
        response.Id,
        response.Name,
        response.Email,
        response.Cpf,
        response.Phone,
        response.Address,
        response.Comments);
}