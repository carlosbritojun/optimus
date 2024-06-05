namespace Optimus.Domain.Entities.Products;

public sealed class InvalidPriceException : Exception
{
    public InvalidPriceException(string message): base(message) { }

    public static void ThrowIf(bool condition, string message)
    {
        if (condition) throw new InvalidPriceException(message);
    }
}
