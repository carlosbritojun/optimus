using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;

namespace Optimus.Tests.Units;

public class ProductTests
{
    [Fact]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = new Name("Produto A");
        var quantityInStock = 100;
        var costPrice = new Money(50);
        var salePrice = new Money(100);
        var comments = new Comments("Teste 1234");

        // Act
        var product = new Product(id, name, quantityInStock, costPrice, salePrice, comments);

        // Assert
        Assert.Equal(id, product.Id);
        Assert.Equal(name, product.Name);
        Assert.Equal(quantityInStock, product.QuantityInStock);
        Assert.Equal(costPrice, product.CostPrice);
        Assert.Equal(salePrice, product.SalePrice);
        Assert.Equal(comments, product.Comments);
        Assert.True(product.CreatedAt <= DateTime.UtcNow);
    }

    [Fact]
    public void ChangeBasicInfo_ShouldUpdateNameAndComments()
    {
        // Arrange
        var product = new Product(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            new Money(50),
            new Money(100),
            new Comments("Teste 1234")
        );

        var newName = new Name("Produto B");
        var newComments = new Comments("New comments");

        // Act
        product.ChangeBasicInfo(newName, newComments);

        // Assert
        Assert.Equal(newName, product.Name);
        Assert.Equal(newComments, product.Comments);
    }

    [Fact]
    public void ChangePrices_ShouldUpdateCostAndSalePrice()
    {
        // Arrange
        var product = new Product(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            new Money(50),
            new Money(100),
            new Comments("Teste 1234")
        );

        var newCostPrice = new Money(40);
        var newSalePrice = new Money(90);

        // Act
        product.ChangePrices(newCostPrice, newSalePrice);

        // Assert
        Assert.Equal(newCostPrice, product.CostPrice);
        Assert.Equal(newSalePrice, product.SalePrice);
    }

    [Fact]
    public void ChangePrices_ShouldThrowException_WhenCostPriceIsGreaterThanOrEqualToSalePrice()
    {
        // Arrange
        var product = new Product(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            new Money(50),
            new Money(100),
            new Comments("Teste 1234")
        );

        var newCostPrice = new Money(90);
        var invalidSalePrice = new Money(80);

        // Act & Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => product.ChangePrices(newCostPrice, invalidSalePrice));
        Assert.Equal("Preco de venda inválido [80]", exception.Message);
    }

    [Fact]
    public void ChangeStock_ShouldUpdateQuantityInStock()
    {
        // Arrange
        var product = new Product(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            new Money(50),
            new Money(100),
            new Comments("Teste 1234")
        );

        var newQuantity = 150;

        // Act
        product.ChangeStock(newQuantity);

        // Assert
        Assert.Equal(newQuantity, product.QuantityInStock);
    }

    [Fact]
    public void ToString_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = new Name("Produto A");
        var product = new Product(
            id,
            name,
            100,
            new Money(50),
            new Money(100),
            new Comments("Teste 1234")
        );

        // Act
        var result = product.ToString();

        // Assert
        var expected = $"Id={id} | Name={name.Value}";
        Assert.Equal(expected, result);
    }
}

