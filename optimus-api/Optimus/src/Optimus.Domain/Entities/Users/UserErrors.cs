using FluentResults;
using Optimus.Domain.Shared.Errors;

namespace Optimus.Domain.Entities.Users;

public static class UserErrors
{
    public static Error NotFound = new EntityNotFoundError("Usuário não localizado");
    public static Error Password = new EntityNotFoundError("Senha inválida");
    public static Error IsInactive = new EntityNotFoundError("Usuário encontra-se inativo");
}
