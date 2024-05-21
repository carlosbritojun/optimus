using FluentValidation;
using Optimus.Api.Controllers.Authentication.V1.Models;

namespace Optimus.Api.Controllers.Authentication.V1.Validations;

public sealed class LoginUserRequestValidator : AbstractValidator<LoginUserRequest>
{
    public LoginUserRequestValidator()
    {
        RuleFor(user => user.Email)
            .NotNull().WithMessage("O e-mail deve ser informado")
            .NotEmpty().WithMessage("O e-mail não deve ser branco")
            .EmailAddress().WithMessage("O e-mail informado é inválido");

        RuleFor(user => user.Password)
            .NotNull().WithMessage("O password deve ser informado")
            .NotEmpty().WithMessage("O password não deve ser branco")
            .Length(4, 10).WithMessage("O password deve ter entre 4 e 10 caracteres");
    }
}
