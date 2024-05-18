using FluentValidation;
using Optimus.Api.Controllers.Authentication.V1.Models;

namespace Optimus.Api.Controllers.Authentication.V1.Validations;

public sealed class LoginUserRequestValidator : AbstractValidator<LoginUserRequest>
{
    public LoginUserRequestValidator()
    {
        RuleFor(user => user.Email)
            .NotNull()
            .NotEmpty()
            .EmailAddress();

        RuleFor(user => user.Password)
            .NotNull()
            .NotEmpty()
            .Length(4, 10);
    }
}
