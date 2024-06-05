using Optimus.Domain.Entities.Products;

namespace Optimus.Tests.Units;

public class MoneyTests
{
    [Fact]
    public void Create_WithValidValue_ShouldReturnMoneyObject()
    {
        // Arrange
        decimal validValue = 100m;

        // Act
        var money = Money.Create(validValue);

        // Assert
        Assert.NotNull(money);
        Assert.Equal(validValue, money.Value);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-100)]
    public void Create_WithInvalidValue_ShouldThrowInvalidPriceException(decimal invalidValue)
    {
        // Act & Assert
        var exception = Assert.Throws<InvalidPriceException>(() => Money.Create(invalidValue));
        Assert.Equal($"Preco inválido [{invalidValue}]", exception.Message);
    }
}
