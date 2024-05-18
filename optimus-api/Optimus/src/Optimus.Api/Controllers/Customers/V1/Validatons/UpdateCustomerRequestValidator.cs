using FluentValidation;
using Optimus.Api.Configuration;
using Optimus.Api.Controllers.Customers.V1.Models;

namespace Optimus.Api.Controllers.Customers.V1.Validatons;

public class UpdateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
{
    public UpdateCustomerRequestValidator()
    {
        RuleFor(customer => customer.Name)
            .NotNull()
            .NotEmpty()
            .Length(5, 100);

        RuleFor(customer => customer.Email)
            .NotNull()
            .NotEmpty()
            .EmailAddress();

        RuleFor(customer => customer.Cpf)
            .NotNull()
            .NotEmpty()
            .Cpf();

        RuleFor(customer => customer.Phone)
           .NotNull()
           .NotEmpty();

        RuleFor(customer => customer.Address)
            .NotNull()
            .NotEmpty()
            .Length(3, 200);

        RuleFor(customer => customer.Comments)
           .MaximumLength(500);
    }
}
