using Optimus.Domain.Entities.Users;

namespace Optimus.Tests.Units;

public class PasswordTests
{
    private const string PasswordValue = "1234";

    [Fact]
    public void Check_ShouldReturnOk_WhenCorrectPassword()
    {
        //Arrange
        var password = new Password(PasswordValue);


        //Act
        password.GenerateHash();
        var result = password.Check(PasswordValue);

        //Assert
        Assert.True(result, password.Value);
    }

    [Fact]
    public void Check_ShouldReturnFalse_WhenWrongPassword()
    {
        //Arrange
        var password = new Password(PasswordValue);

        //Act
        var result = password.Check(new string(PasswordValue.Reverse().ToArray()));

        //Assert
        Assert.False(result, password.Value);
    }
}
