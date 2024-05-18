namespace Optimus.Application.Features.Customers.GetAll;

public sealed record CustomerListResponse(
    Guid Id,
    string Name,
    string Email);
