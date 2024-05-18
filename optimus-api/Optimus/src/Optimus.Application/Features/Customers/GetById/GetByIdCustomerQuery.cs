using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Customers.GetById;

public sealed record GetByIdCustomerQuery(Guid Id) : IRequest<Result<CustomerResponse>>;
