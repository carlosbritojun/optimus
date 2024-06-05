using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;

namespace Optimus.Tests.Units;

public class ProductTests
{
    [Fact]
    public void Create_WithValidInputs_ShouldReturnProduct()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = new Name("Test Product");
        int quantityInStock = 10;
        var costPrice = Money.Create(50);
        var salePrice = Money.Create(100);
        var comments = new Comments("Test Comments");

        // Act
        var product = Product.Create(id, name, quantityInStock, costPrice, salePrice, comments);

        // Assert
        Assert.NotNull(product);
        Assert.Equal(id, product.Id);
        Assert.Equal(name, product.Name);
        Assert.Equal(quantityInStock, product.QuantityInStock);
        Assert.Equal(costPrice, product.CostPrice);
        Assert.Equal(salePrice, product.SalePrice);
        Assert.Equal(comments, product.Comments);
        Assert.Equal(DateTime.UtcNow, product.CreatedAt, TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void Create_WithInvalidSalePrice_ShouldThrowInvalidPriceException()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = new Name("Test Product");
        int quantityInStock = 10;
        var costPrice = Money.Create(100);
        var salePrice = Money.Create(50);
        var comments = new Comments("Test Comments");

        // Act & Assert
        var exception = Assert.Throws<InvalidPriceException>(() => Product.Create(id, name, quantityInStock, costPrice, salePrice, comments));
        Assert.Equal($"Preco de venda inválido [{salePrice.Value}]", exception.Message);
    }

    [Fact]
    public void ChangeBasicInfo_ShouldUpdateNameAndComments()
    {
        // Arrange
        var product = Product.Create(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            Money.Create(50),
            Money.Create(100),
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
        var product = Product.Create(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            Money.Create(50),
            Money.Create(100),
            new Comments("Teste 1234")
        );

        var newCostPrice = Money.Create(40);
        var newSalePrice = Money.Create(90);

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
        var product = Product.Create(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            Money.Create(50),
            Money.Create(100),
            new Comments("Teste 1234")
        );

        var newCostPrice = Money.Create(90);
        var invalidSalePrice = Money.Create(80);

        // Act & Assert
        var exception = Assert.Throws<InvalidPriceException>(() => product.ChangePrices(newCostPrice, invalidSalePrice));
        Assert.Equal("Preco de venda inválido [80]", exception.Message);
    }

    [Fact]
    public void ChangeStock_ShouldUpdateQuantityInStock()
    {
        // Arrange
        var product = Product.Create(
            Guid.NewGuid(),
            new Name("Produto A"),
            100,
            Money.Create(50),
            Money.Create(100),
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
        var product = Product.Create(
            id,
            name,
            100,
            Money.Create(50),
            Money.Create(100),
            new Comments("Teste 1234")
        );

        // Act
        var result = product.ToString();

        // Assert
        var expected = $"Id={id} | Name={name.Value}";
        Assert.Equal(expected, result);
    }
}

