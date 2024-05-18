using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Shared;

namespace Optimus.Application.Features.Customers.Create;

public sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result<Guid>>
{
    public CreateCustomerCommandHandler(ICustomerRepository repository, IUnitOfWork transaction)
    {
        _repository = repository;
        _transaction = transaction;
    }
    
    private readonly ICustomerRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result<Guid>> Handle(CreateCustomerCommand request, CancellationToken token = default)
    {
        var email = new Email(request.Email);
        var cpf = new Cpf(request.Cpf);

        if (await _repository.EmailExistsAsync(email))
        {
            return Result.Fail(CustomerErrors.EmailExists(email));
        }

        if (await _repository.CpfExistsAsync(cpf))
        {
            return Result.Fail(CustomerErrors.CpfExists(cpf));
        }

        var customer = new Customer(
            Guid.NewGuid(),
            new Name(request.Name),
            email,
            cpf,
            new Phone(request.Phone),
            new Address(request.Address),
            new Comments(request.Comments ?? string.Empty));

        await _repository.AddAsync(customer, token);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok(customer.Id);
    }
}
