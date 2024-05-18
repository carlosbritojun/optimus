namespace Optimus.Domain.Entities.Users;

public sealed record Password
{
    public string Value { get; private set; }

    public Password(string value)
    {
        Value = value;
    }

    public bool Check(string password) => Hash.Generate(password) == this.Value;
    public void GenerateHash() => Value = Hash.Generate(this.Value); 

}