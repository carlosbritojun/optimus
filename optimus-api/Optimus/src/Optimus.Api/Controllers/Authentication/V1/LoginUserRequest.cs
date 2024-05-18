using Optimus.Application.Features.Authentication;

namespace Optimus.Api.Controllers.Authentication.V1;

public sealed record LoginUserRequest(
    string Email, 
    string Password)
{
    public LoginUserCommand ToCommand() => new(Email, Password);
}

