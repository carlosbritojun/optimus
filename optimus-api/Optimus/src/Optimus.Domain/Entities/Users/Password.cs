using Cypher = BCrypt.Net;

namespace Optimus.Domain.Entities.Users;

public sealed record Password
{
    public string Value { get; }

    public Password(string value)
    {
        Value = Cypher.BCrypt.HashPassword(value);
    }

    public bool Check(string password) => Cypher.BCrypt.Verify(password, this.Value);
}