using FluentResults;
using MediatR;
using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Shared;

namespace Optimus.Application.Features.Customers.Create;

public sealed class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Result>
{
    public UpdateCustomerCommandHandler(ICustomerRepository repository, IUnitOfWork transaction)
    {
        _repository = repository;
        _transaction = transaction;
    }
    
    private readonly ICustomerRepository _repository;
    private readonly IUnitOfWork _transaction;

    public async Task<Result> Handle(UpdateCustomerCommand request, CancellationToken token = default)
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

        var customer = await _repository.GetByIdAsync(request.Id, token);

        if (customer is null)
        {
            return Result.Fail(CustomerErrors.NotFound);
        }

        customer.ChangeBasicInfo(
            new Name(request.Name), 
            new Email(request.Name), 
            new Cpf(request.Cpf), 
            new Comments(request.Comments ?? string.Empty));

        customer.ChangeContactInfo(
            new Phone(request.Phone), 
            new Address(request.Address));

        _repository.Update(customer);
        await _transaction.SaveChangesAsync(token);

        return Result.Ok();
    }
}
