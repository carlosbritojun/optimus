using FluentValidation;
using Optimus.Api.Controllers.Products.V1.Models;

namespace Optimus.Api.Controllers.Products.V1.Validations;

public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(product => product.Name)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O nome deve ser informado")
            .NotEmpty().WithMessage("O nome não deve estar em branco")
            .Length(5, 100).WithMessage("O nome deve ter entre 5 e 100 caracteres");

        RuleFor(product => product.QuantityInStock)
            .NotNull().WithMessage("A quantidade em estoque deve ser informada")
            .NotEmpty().WithMessage("A quantidade em estoque não deve estar em branco");

        RuleFor(product => product.CostPrice)
            .Cascade(CascadeMode.StopOnFirstFailure)
             .NotNull().WithMessage("O preço de custo deve ser informada")
            .NotEmpty().WithMessage("O preço de custo não deve estar em branco")
            .GreaterThanOrEqualTo(0).WithMessage("O preço de custo deve ser maior do que zero");

        RuleFor(product => product.SalePrice)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("O preço de venda deve ser informada")
            .NotEmpty().WithMessage("O preço de venda não deve estar em branco")
            .GreaterThanOrEqualTo(0).WithMessage("O preço de venda deve ser maior do que zero")
            .GreaterThan(product => product.CostPrice).WithMessage("O preço de venda deve ser maior do que o preço de custo");

        RuleFor(product => product.Comments)
            .MaximumLength(500);
    }
}
