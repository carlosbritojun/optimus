using FluentResults;
using Optimus.Domain.Shared.Errors;

namespace Optimus.Domain.Entities.Products;

public static class ProductErrors
{
    public static Error NotFound = new EntityNotFoundError("Produto não localizado");
    public static Error NameExists => new Error("Um produto com o nome informado já existe");
}
