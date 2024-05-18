using Caelum.Stella.CSharp.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using V1Customers = Optimus.Api.Controllers.Customers.V1.Validations;
using V1Product = Optimus.Api.Controllers.Products.V1.Validations;

namespace Optimus.Api.Configuration;

public static class ValidatorConfiguration
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        AddV1Validators(services);
        services.AddFluentValidationAutoValidation();

        return services;
    }

    private static IServiceCollection AddV1Validators(this IServiceCollection services)
    {
        #region V1 Customers
        services.AddValidatorsFromAssemblyContaining<V1Customers.CreateCustomerRequestValidator>();
        services.AddValidatorsFromAssemblyContaining<V1Customers.UpdateCustomerRequestValidator>();
        #endregion

        #region V1 Products
        services.AddValidatorsFromAssemblyContaining<V1Product.CreateProductRequestValidator>();
        services.AddValidatorsFromAssemblyContaining<V1Product.UpdateProductRequestValidator>();
        #endregion

        return services;
    }

    public static IRuleBuilderOptions<T, string> Cpf<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.Must(cpf => new CPFValidator().IsValid(cpf));
    }
}
