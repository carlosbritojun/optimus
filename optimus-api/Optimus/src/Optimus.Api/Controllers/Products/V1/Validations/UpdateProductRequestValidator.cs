﻿using FluentValidation;
using Optimus.Api.Controllers.Products.V1.Models;

namespace Optimus.Api.Controllers.Products.V1.Validations;

public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
{
    public UpdateProductRequestValidator()
    {
        RuleFor(product => product.Name)
            .NotNull()
            .NotEmpty()
            .Length(5, 100);

        RuleFor(product => product.QuantityInStock)
            .GreaterThan(0);

        RuleFor(product => product.CostPrice)
            .NotNull()
            .NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(product => product.SalePrice)
            .NotNull()
            .NotEmpty()
            .GreaterThanOrEqualTo(0)
            .GreaterThan(product => product.CostPrice);

        RuleFor(product => product.Comments)
            .MaximumLength(500);
    }
}
