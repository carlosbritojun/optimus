using Optimus.Domain.Abstractions;
using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Products;

public sealed class Product : Entity
{
    private static string InvalidSalePrice(decimal price) => $"Preco de venda inválido [{price}]";

    private Product(Guid id, Name name, int quantityInStock, Comments? comments=null)
        : base(id)
    {
        Name = name;
        QuantityInStock = quantityInStock;
        Comments = comments;
        CreatedAt = DateTime.UtcNow;
    }

    public Name Name { get; private set; }
    public int QuantityInStock { get; private set; }
    public Money CostPrice { get; private set; }
    public Money SalePrice { get; private set; }
    public Comments? Comments { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public static Product Create(Guid id, Name name, int quantityInStock, Money costPrice, Money salePrice, Comments? comments)
    {
        var product = new Product(id, name, quantityInStock, comments);
        product.ChangePrices(costPrice, salePrice);
        return product;
    }

    public void ChangeBasicInfo(Name name, Comments? comments=null)
    {
        Name = name;
        Comments = comments;
    }

    public void ChangePrices(Money costPrice, Money salePrice)
    {
        InvalidPriceException.ThrowIf(costPrice.Value >= salePrice.Value, InvalidSalePrice(salePrice.Value));

        CostPrice = costPrice;
        SalePrice = salePrice;
    }

    public void  ChangeStock(int newQuantity)
    {
        QuantityInStock = newQuantity;
    }

    public override string ToString() => $"Id={Id} | Name={Name.Value}";
}
