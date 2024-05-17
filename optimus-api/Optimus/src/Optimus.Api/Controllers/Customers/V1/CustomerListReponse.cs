namespace Optimus.Api.Controllers.Customers.V1;

public sealed record CustomerListResponse(
    Guid Id,
    string Name,
    string Email);
