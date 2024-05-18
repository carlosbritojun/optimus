using FluentResults;
using MediatR;
using Optimus.Domain.Entities.Customers;

namespace Optimus.Application.Features.Customers.GetById;

internal sealed class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQuery, Result<CustomerResponse>>
{
    public GetByIdCustomerQueryHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }

    private readonly ICustomerRepository _repository;

    public async Task<Result<CustomerResponse>> Handle(GetByIdCustomerQuery request, CancellationToken token = default)
    {
        var customer = await _repository.GetByIdAsync(request.Id, token);

        if (customer is null)
        {
            return Result.Fail(CustomerErrors.NotFound);
        }

        return Result.Ok(new CustomerResponse(
            customer.Id,
            customer.Name.Value,
            customer.Email.Address,
            customer.Cpf.Document,
            customer.Phone.Value,
            customer.Address.Value,
            customer.Comments?.Value));
    }
}
