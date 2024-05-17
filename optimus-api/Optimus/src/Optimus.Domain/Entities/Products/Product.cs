using Optimus.Domain.Abstractions;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Products;

public sealed class Product : Entity
{
    private static string PrecoDeVendaInvalido(decimal preco) => $"Preco de venda inválido [{preco}]";

    public Product(Guid id, Name name, int quantityInStock, Money costPrice, Money salePrice, Comments comments)
        : base(id)
    {
        Name = name;
        QuantityInStock = quantityInStock;
        CostPrice = costPrice;
        SalePrice = salePrice;
        Comments = comments;
    }

    public Name Name { get; private set; }
    public int QuantityInStock { get; private set; }
    public Money CostPrice { get; private set; }
    public Money SalePrice { get; private set; }
    public Comments? Comments { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public void ChangeBasicInfo(Name name, Comments? comments=null)
    {
        Name = name;
        Comments = comments;
    }

    public void ChangePrices(Money costPrice, Money saleCost)
    {
        if (costPrice.Value >= saleCost.Value)
        {
            throw new ArgumentOutOfRangeException(null, PrecoDeVendaInvalido(saleCost.Value));
        }

        CostPrice = costPrice;
        SalePrice = saleCost;
    }

    public void  ChangeStock(int newQuantity)
    {
        QuantityInStock = newQuantity;
    }

    public override string ToString() => $"Id={Id} | Name={Name.Value}";
}
