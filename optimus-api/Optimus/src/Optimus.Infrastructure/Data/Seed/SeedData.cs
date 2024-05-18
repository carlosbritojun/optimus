using Bogus;
using Bogus.Extensions.Brazil;
using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Customers;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Entities.Users;
using Optimus.Domain.Shared;

namespace Optimus.Infrastructure.Data.Seed;

internal static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedDefaultUsers(modelBuilder);
        SeedProducts(modelBuilder);
        //SeedCustomers(modelBuilder);
    }

    public static void SeedDefaultUsers(ModelBuilder modelBuilder)
    {
        var password = new Password("1234");
        password.GenerateHash();

        User[] users = [
            new (Guid.NewGuid(), new Email("admin@optimus.com"), EProfile.Administrator, password),
            new (Guid.NewGuid(), new Email("operador@optimus.com"), EProfile.Operator, password)
        ];

        modelBuilder.Entity<User>().HasData(users);
    }

    public static void SeedProducts(ModelBuilder modelBuilder)
    {
        var faker = new Faker("pt_BR");

        var products = Enumerable.Range(1, 20).Select(number =>
        {
            var cost = new Money(faker.Random.Int(5, 15));

            return new Product(
                id: Guid.NewGuid(),
                name: new Name(faker.Commerce.ProductName()),
                quantityInStock: faker.Random.Int(-2, 10),
                costPrice: cost,
                salePrice: new Money(cost.Value * 2),
                comments: new Comments(faker.Commerce.ProductDescription())); 
        });

        modelBuilder.Entity<Product>().HasData(products);
    }

    public static void SeedCustomers(ModelBuilder modelBuilder)
    {
        var faker = new Faker("pt_BR");

        var customers = Enumerable.Range(1, 10).Select(number =>
        {
            return new Customer(
                id: Guid.NewGuid(),
                name: new Name(faker.Person.FullName),
                email: new Email(faker.Person.Email),
                cpf: new Cpf(faker.Person.Cpf()),
                phone: new Phone(faker.Phone.PhoneNumber()),
                address: new Address(faker.Address.FullAddress()),
                comments: new Comments(faker.Lorem.Text()));

        });

        modelBuilder.Entity<Customer>().HasData(customers);
    }
}
