namespace Optimus.Domain.Entities.Products;

public sealed record class Money
{
    private static string InvalidValue(decimal value) => $"Preco inválido [{value}]";

    public decimal Value { get; private set; }

    private Money(decimal value) => this.Value = value;

    public static Money Create(decimal value)
    {
        InvalidPriceException.ThrowIf(value <= decimal.Zero, InvalidValue(value));
        return new Money(value);
    }
}