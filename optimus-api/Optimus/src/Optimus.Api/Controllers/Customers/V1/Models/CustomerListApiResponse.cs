using Optimus.Application.Features.Customers.GetAll;

namespace Optimus.Api.Controllers.Customers.V1.Models;

public sealed record CustomerListApiResponse(
    Guid Id,
    string Name,
    string Email)
{
    public static CustomerListApiResponse From(CustomerListResponse response) => new CustomerListApiResponse(
        response.Id,
        response.Name,
        response.Email);
}
