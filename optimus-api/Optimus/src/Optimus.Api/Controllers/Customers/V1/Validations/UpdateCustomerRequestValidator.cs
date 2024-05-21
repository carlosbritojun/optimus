using FluentValidation;
using Optimus.Api.Configuration;
using Optimus.Api.Controllers.Customers.V1.Models;

namespace Optimus.Api.Controllers.Customers.V1.Validations;

public class UpdateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
{
    public UpdateCustomerRequestValidator()
    {
        RuleFor(customer => customer.Name)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O nome deve ser informado")
            .NotEmpty().WithMessage("O nome não pode estar em branco")
            .Length(5, 100).WithMessage("O nome deve ter entre 5 e 100 caracteres");

        RuleFor(customer => customer.Email)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O e-mail deve ser informado")
            .NotEmpty().WithMessage("O e-mail pode estar em branco")
            .EmailAddress().WithMessage("O e-mail informado é inválido");

        RuleFor(customer => customer.Cpf)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O CPF deve ser informado")
            .NotEmpty().WithMessage("O CPF não pode estar em branco")
            .Cpf().WithMessage("O CPF deve informado é inválido");

        RuleFor(customer => customer.Phone)
            .Cascade(CascadeMode.StopOnFirstFailure)
           .NotNull().WithMessage("O telefone deve ser informado")
           .NotEmpty().WithMessage("O telefone não deve estar em branco");

        RuleFor(customer => customer.Address)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O endereço deve ser informado")
            .NotEmpty().WithMessage("O endereço não pode estar em branco")
            .Length(3, 200).WithMessage("O endereço deve ter entre 3 e 200 caracteres");

        RuleFor(customer => customer.Comments)
           .MaximumLength(500);
    }
}
