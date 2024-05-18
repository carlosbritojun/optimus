using MediatR;

namespace Optimus.Application.Features.Customers.GetAll;

public sealed record GetAllCustomersQuery : IRequest<IReadOnlyList<CustomerListResponse>>;