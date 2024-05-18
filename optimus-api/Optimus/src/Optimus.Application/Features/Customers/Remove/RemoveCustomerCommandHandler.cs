using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Customers;

namespace Optimus.Application.Features.Customers.Remove;

internal sealed class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand, Result>
{
    public RemoveCustomerCommandHandler(ICustomerRepository repository, IUnitOfWork transaction)
    {
        _repository = repository;
        _transaction = transaction;
    }

    private readonly ICustomerRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result> Handle(RemoveCustomerCommand request, CancellationToken token = default)
    {
        var customer = await _repository.GetByIdAsync(request.Id, token);

        if (customer is null)
        {
            return Result.Fail(CustomerErrors.NotFound);
        }

        _repository.Remove(customer);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok();
    }
}
