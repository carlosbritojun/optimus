using Optimus.Domain.Abstractions;
using Optimus.Domain.Shared;

namespace Optimus.Domain.Entities.Users;

public sealed class User : Entity
{
    public User(Guid id, Email email, EProfile profile, Password password)
        : base(id)
    {
        Email = email;
        Profile = profile;
        Password = password;
        CreatedAt = DateTime.UtcNow;
    }

    public Email Email { get; private set; }
    public EProfile Profile { get; private set; }
    public Password Password { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? InactivatedAt { get; private set; }

    public bool IsActive() => InactivatedAt is null;

    public void Activate() => InactivatedAt = null;

    public void Inactivate() => InactivatedAt = DateTime.UtcNow;

    public void ChangeEmail(Email email) => Email = email;

    public void ChangePassword(Password password) => Password = password;

    public void BecomeAdministrator() => Profile = EProfile.Administrator;

    public void BecomeOperator() => Profile = EProfile.Operator;

    public bool CheckPassword(string password) => Password.Check(password);

    public override string ToString() =>  $"Id={Id} | Name={Email.Address}";
}
