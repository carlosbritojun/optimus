using FluentResults;
using Optimus.Domain.Shared;
using Optimus.Domain.Shared.Errors;

namespace Optimus.Domain.Entities.Customers;

public static class CustomerErrors
{
    public static Error NotFound = new EntityNotFoundError($"Cliente não localizado");
    public static Error EmailExists(Email email) => new Error($"E e-mail {email.Address} já encontra-se cadastrado");
    public static Error CpfExists(Cpf cpf) => new Error($"O cpf {cpf.Document} já encontra-se cadastrado");
}
