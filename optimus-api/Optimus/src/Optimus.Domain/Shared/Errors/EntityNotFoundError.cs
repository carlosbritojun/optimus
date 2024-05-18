using FluentResults;

namespace Optimus.Domain.Shared.Errors;

public sealed class EntityNotFoundError(string mensagem) : Error(mensagem);