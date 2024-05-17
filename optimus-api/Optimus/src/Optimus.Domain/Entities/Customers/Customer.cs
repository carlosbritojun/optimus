using Optimus.Domain.Abstractions;
using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Customers;

public sealed class Customer : Entity
{
    public Customer(Guid id, Name name, Email email, Cpf cpf, Phone phone, Address address, Comments? comments)
        : base(id)
    {
        Name = name;
        Email = email;
        Cpf = cpf;
        Phone = phone;
        Address = address;
        Comments = comments;
    }

    protected Customer() { }

    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Cpf Cpf { get; private set; }
    public Phone Phone { get; private set; }
    public Address Address { get; private set; }
    public Comments? Comments { get; private set; }

    public void ChangeBasicInfo(Name name, Email email, Cpf cpf, Comments comments)
    {
        Name = name;
        Email = email;
        Cpf = cpf;
        Comments = comments;
    }
    
    public void ChangeContactInfo(Phone phone, Address address)
    {
        Phone = phone;
        Address = address;
    }

    public override string ToString() => $"Id={Id} | Name={Name.Value}";
}
